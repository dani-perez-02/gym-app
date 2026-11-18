using gym_app.Configuration;
using Npgsql;
using NpgsqlTypes;

namespace gym_app.Membership
{
    internal class SqlMembershipRepository : IMembershipRepository
    {
        public void Save(Membership membership)
        {
            const string sql = """
                INSERT INTO Memberships (MemberId, PlanId, StartDate, EndDate, Status)
                VALUES (@MemberId, @PlanId, @StartDate, @EndDate, @Status)
                RETURNING MembershipId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@MemberId", NpgsqlDbType.Integer).Value = membership.MemberId;
            cmd.Parameters.Add("@PlanId", NpgsqlDbType.Integer).Value = membership.PlanId;
            cmd.Parameters.Add("@StartDate", NpgsqlDbType.Date).Value = membership.StartDate.Date;
            cmd.Parameters.Add("@EndDate", NpgsqlDbType.Date).Value = membership.EndDate.Date;
            cmd.Parameters.Add("@Status", NpgsqlDbType.Varchar, 20).Value = membership.Status;

            conn.Open();
            var result = cmd.ExecuteScalar();
            if (result != null)
                membership.MembershipId = Convert.ToInt32(result);
        }

        public void UpdateStatus(int membershipId, string status)
        {
            const string sql = """
                UPDATE Memberships
                SET Status = @Status
                WHERE MembershipId = @MembershipId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@MembershipId", NpgsqlDbType.Integer).Value = membershipId;
            cmd.Parameters.Add("@Status", NpgsqlDbType.Varchar, 20).Value = status;

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void ExpireOutdatedMemberships()
        {
            const string sql = """
                UPDATE Memberships
                SET Status = 'VENCIDA'
                WHERE Status = 'VIGENTE' AND EndDate < CURRENT_DATE;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public bool HasActiveMembership(int memberId)
        {
            const string sql = """
                SELECT EXISTS (
                    SELECT 1
                    FROM Memberships
                    WHERE MemberId = @MemberId
                      AND Status = 'VIGENTE'
                      AND EndDate >= CURRENT_DATE
                );
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@MemberId", NpgsqlDbType.Integer).Value = memberId;

            conn.Open();
            return (bool)(cmd.ExecuteScalar() ?? false);
        }

        public IEnumerable<Membership> GetAll()
        {
            const string sql = """
                SELECT ms.MembershipId, ms.MemberId, ms.PlanId,
                       ms.StartDate, ms.EndDate, ms.Status,
                       m.Rut AS MemberRut, m.Name AS MemberName,
                       p.Name AS PlanName
                FROM Memberships ms
                JOIN Members m ON m.MemberId = ms.MemberId
                JOIN Plans p ON p.PlanId = ms.PlanId
                ORDER BY ms.MembershipId DESC;
                """;

            var list = new List<Membership>();

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Membership
                {
                    MembershipId = reader.GetInt32(reader.GetOrdinal("MembershipId")),
                    MemberId = reader.GetInt32(reader.GetOrdinal("MemberId")),
                    PlanId = reader.GetInt32(reader.GetOrdinal("PlanId")),
                    StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate")),
                    EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate")),
                    Status = reader.GetString(reader.GetOrdinal("Status")),
                    MemberRut = reader.GetString(reader.GetOrdinal("MemberRut")),
                    MemberName = reader.GetString(reader.GetOrdinal("MemberName")),
                    PlanName = reader.GetString(reader.GetOrdinal("PlanName"))
                });
            }

            return list;
        }
    }
}