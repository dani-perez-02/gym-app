using gym_app.Configuration;
using Npgsql;
using NpgsqlTypes;

namespace gym_app.Member
{
    internal class SqlMemberRepository : IMemberRepository
    {
        public void Save(Member member)
        {
            const string sql = """
                INSERT INTO Members (Rut, Name, Phone, Email)
                VALUES (@Rut, @Name, @Phone, @Email)
                RETURNING MemberId, RegisteredAt;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@Rut", NpgsqlDbType.Varchar, 12).Value = member.Rut;
            cmd.Parameters.Add("@Name", NpgsqlDbType.Varchar, 100).Value = member.Name;
            cmd.Parameters.Add("@Phone", NpgsqlDbType.Varchar, 20).Value = member.Phone;
            cmd.Parameters.Add("@Email", NpgsqlDbType.Varchar, 100).Value = ToDbValue(member.Email);

            try
            {
                conn.Open();
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    member.MemberId = reader.GetInt32(0);
                    member.RegisteredAt = reader.GetDateTime(1);
                    member.IsActive = true;
                }
            }
            catch (PostgresException ex) when (ex.SqlState == PostgresErrorCodes.UniqueViolation)
            {
         
                throw new InvalidOperationException("Ya existe un socio registrado con ese RUT.", ex);
            }
        }

        public void Update(Member member)
        {
            const string sql = """
                UPDATE Members
                SET Name = @Name, Phone = @Phone, Email = @Email
                WHERE MemberId = @MemberId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@MemberId", NpgsqlDbType.Integer).Value = member.MemberId;
            cmd.Parameters.Add("@Name", NpgsqlDbType.Varchar, 100).Value = member.Name;
            cmd.Parameters.Add("@Phone", NpgsqlDbType.Varchar, 20).Value = member.Phone;
            cmd.Parameters.Add("@Email", NpgsqlDbType.Varchar, 100).Value = ToDbValue(member.Email);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeactivateById(int memberId)
        {
            const string sql = """
                UPDATE Members
                SET IsActive = FALSE
                WHERE MemberId = @MemberId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@MemberId", NpgsqlDbType.Integer).Value = memberId;

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<Member> GetAll(MemberFilter.MembersFilter filtro)
        {

            string whereClause = filtro switch
            {
                MemberFilter.MembersFilter.Activo => "WHERE IsActive = TRUE",
                MemberFilter.MembersFilter.Inactivo => "WHERE IsActive = FALSE",
                _ => ""
            };

            string sql = $"""        
                        SELECT MemberId, Rut, Name, Phone, Email, RegisteredAt, IsActive
                        FROM Members        
                        {whereClause}
                        ORDER BY Name;
                        """;

            var members = new List<Member>();

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                members.Add(MapReaderToMember(reader));

            return members;
        }



        public Member? GetMemberByRut(string rut)
        {
            const string sql = """
                SELECT MemberId, Rut, Name, Phone, Email, RegisteredAt, IsActive
                FROM Members
                WHERE Rut = @Rut AND IsActive = TRUE
                LIMIT 1;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@Rut", NpgsqlDbType.Varchar, 12).Value = rut;

            conn.Open();
            using var reader = cmd.ExecuteReader();

            return reader.Read() ? MapReaderToMember(reader) : null;
        }

        // para convertir un string vacío o null en DBNull, pg no acepta null
        private static object ToDbValue(string? value)
            => string.IsNullOrWhiteSpace(value) ? DBNull.Value : value;

        private static Member MapReaderToMember(NpgsqlDataReader reader)
        {
            return new Member
            {
                MemberId = reader.GetInt32(reader.GetOrdinal("MemberId")),
                Rut = reader.GetString(reader.GetOrdinal("Rut")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                // email pueed ser null por ahora
                Email = reader.IsDBNull(reader.GetOrdinal("Email"))
                    ? string.Empty
                    : reader.GetString(reader.GetOrdinal("Email")),
                RegisteredAt = reader.GetDateTime(reader.GetOrdinal("RegisteredAt")),
                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"))
            };
        }
    }
}
