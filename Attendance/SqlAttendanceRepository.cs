using gym_app.Configuration;
using Npgsql;
using NpgsqlTypes;

namespace gym_app.Attendance
{
    internal class SqlAttendanceRepository : IAttendanceRepository
    {
        public void Save(int memberId)
        {
            const string sql = """
                INSERT INTO Attendance (MemberId)
                VALUES (@MemberId);
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@MemberId", NpgsqlDbType.Integer).Value = memberId;

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // query de abajo: 
        // el coalesce devuelve el primer valor q no sea null, si el socio no tiene plan p.Name es null y muestra "sin plan"
        public IEnumerable<Attendance> GetTodayAttendance()
        {
            const string sql = """
                SELECT a.AttendanceId, a.MemberId, a.EntranceDateTime,
                       m.Rut AS MemberRut, m.Name AS MemberName,
                       COALESCE(p.Name, 'Sin plan') AS PlanName
                FROM Attendance a
                JOIN Members m ON m.MemberId = a.MemberId
                LEFT JOIN LATERAL (
                    SELECT ms.PlanId
                    FROM Memberships ms
                    WHERE ms.MemberId = a.MemberId
                    ORDER BY ms.EndDate DESC
                    LIMIT 1
                ) last_ms ON TRUE
                LEFT JOIN Plans p ON p.PlanId = last_ms.PlanId
                WHERE a.EntranceDateTime::date = CURRENT_DATE
                ORDER BY a.EntranceDateTime DESC;
                """;

            var list = new List<Attendance>();

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Attendance // mover a mapper?
                {
                    AttendanceId = reader.GetInt32(reader.GetOrdinal("AttendanceId")),
                    MemberId = reader.GetInt32(reader.GetOrdinal("MemberId")),
                    EntranceDateTime = reader.GetDateTime(reader.GetOrdinal("EntranceDateTime")),
                    MemberRut = reader.GetString(reader.GetOrdinal("MemberRut")),
                    MemberName = reader.GetString(reader.GetOrdinal("MemberName")),
                    PlanName = reader.GetString(reader.GetOrdinal("PlanName"))
                });
            }

            return list;
        }
    }
}