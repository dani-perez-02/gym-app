using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gym_app.Configuration;

namespace gym_app.Member
{
    internal class SqlMemberRepository : IMemberRepository
    {
        public void Save(Member member)
        {
            const string sql = """
                INSERT INTO Members (Rut, Name, Phone, Email)
                VALUES (@Rut, @Name, @Phone, @Email);
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 12).Value = member.Rut;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = member.Name;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = member.Phone;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = member.Email;

            conn.Open();
            cmd.ExecuteNonQuery();

        }

        public void Update(Member member)
        {
            const string sql = """
                UPDATE Members
                SET Name = @Name, Phone = @Phone, Email = @Email
                WHERE MemberId = @MemberId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@MemberId", SqlDbType.Int).Value = member.MemberId;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = member.Name;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = member.Phone;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = member.Email;

            conn.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeactivateById(int memberId)
        {
            const string sql = """
                UPDATE Members SET IsActive = 0
                WHERE MemberId = @MemberId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@MemberId", SqlDbType.Int).Value = memberId;

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<Member> GetAll()
        {
            const string sql = """
                SELECT MemberId, Rut, Name, Phone, Email, RegisteredAt, IsActive
                FROM Members
                WHERE IsActive = 1;
                """;

            var members = new List<Member>();

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                members.Add(MapReaderToMember(reader));

            return members;
        }

        public Member GetMemberByRut(string rut)
        {
            const string sql = """
                SELECT TOP 1 MemberId, Rut, Name, Phone, Email, RegisteredAt, IsActive
                FROM Members
                WHERE Rut = @Rut AND IsActive = 1;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Rut", SqlDbType.VarChar, 12).Value = rut;

            conn.Open();
            using var reader = cmd.ExecuteReader();

            return reader.Read() ? MapReaderToMember(reader) : null;
        }

        private static Member MapReaderToMember(SqlDataReader reader)
        {
            return new Member
            {
                MemberId = Convert.ToInt32(reader["MemberId"]),
                Rut = reader["Rut"].ToString(),
                Name = reader["Name"].ToString(),
                Phone = reader["Phone"].ToString(),
                Email = reader["Email"].ToString(),
                RegisteredAt = Convert.ToDateTime(reader["RegisteredAt"]),
                IsActive = Convert.ToBoolean(reader["IsActive"])
            };
        }


    }
}
