using gym_app.Configuration;
using Npgsql;
using NpgsqlTypes;

namespace gym_app.Plan
{
    internal class SqlPlanRepository : IPlanRepository
    {
        public void Save(Plan plan)
        {
            const string sql = """
                INSERT INTO Plans (Name, DurationInDays, Price)
                VALUES (@Name, @DurationInDays, @Price)
                RETURNING PlanId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@Name", NpgsqlDbType.Varchar, 50).Value = plan.Name;
            cmd.Parameters.Add("@DurationInDays", NpgsqlDbType.Integer).Value = plan.DurationInDays;
            cmd.Parameters.Add("@Price", NpgsqlDbType.Integer).Value = plan.Price;

            conn.Open();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                plan.PlanId = Convert.ToInt32(result);
                plan.IsActive = true;
            }
        }

        public void Update(Plan plan)
        {
            const string sql = """
                UPDATE Plans
                SET Name = @Name, DurationInDays = @DurationInDays, Price = @Price
                WHERE PlanId = @PlanId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@PlanId", NpgsqlDbType.Integer).Value = plan.PlanId;
            cmd.Parameters.Add("@Name", NpgsqlDbType.Varchar, 50).Value = plan.Name;
            cmd.Parameters.Add("@DurationInDays", NpgsqlDbType.Integer).Value = plan.DurationInDays;
            cmd.Parameters.Add("@Price", NpgsqlDbType.Integer).Value = plan.Price;

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeactivateById(int planId)
        {
            const string sql = """
                UPDATE Plans
                SET IsActive = FALSE
                WHERE PlanId = @PlanId;
                """;

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.Add("@PlanId", NpgsqlDbType.Integer).Value = planId;

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<Plan> GetAll()
        {
            const string sql = """
                SELECT PlanId, Name, DurationInDays, Price, IsActive
                FROM Plans
                WHERE IsActive = TRUE
                ORDER BY Name;
                """;

            var plans = new List<Plan>();

            using var conn = DatabaseConfig.CreateConnection();
            using var cmd = new NpgsqlCommand(sql, conn);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                plans.Add(MapReaderToPlan(reader));

            return plans;
        }

        private static Plan MapReaderToPlan(NpgsqlDataReader reader)
        {
            return new Plan
            {
                PlanId = reader.GetInt32(reader.GetOrdinal("PlanId")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                DurationInDays = reader.GetInt32(reader.GetOrdinal("DurationInDays")),
                Price = reader.GetInt32(reader.GetOrdinal("Price")),
                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"))
            };
        }
    }
}