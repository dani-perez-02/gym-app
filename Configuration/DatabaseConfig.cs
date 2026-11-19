using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace gym_app.Configuration
{
    internal class DatabaseConfig
    {
        // private const string EnvVarName = "GYM_DB_CONNECTION";
        private const string EnvVarName = "Host=ep-muddy-truth-b628am8q-pooler.c-2.sa-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_UlyemwEcY20J;SSL Mode=Require;Timeout=30";

     //   private static string GetConnectionString()
    //    {
     //       var connStr = Environment.GetEnvironmentVariable(EnvVarName);
     //       if (string.IsNullOrWhiteSpace(connStr))
     //           throw new InvalidOperationException(
     //               $"No se encontró la variable de entorno '{EnvVarName}'.");
     //
     //       return connStr;
     //   }

        private static string GetConnectionString()
        {
   
            return EnvVarName;
        }


        public static NpgsqlConnection CreateConnection()
            => new NpgsqlConnection(GetConnectionString());


        public static bool TestConnection(out string errorMessage)
        {
            try
            {
                using var conn = CreateConnection();
                conn.Open();
                errorMessage = string.Empty;
                return true;
            }
            catch (InvalidOperationException ex)
            {
                errorMessage = ex.Message;
                return false;
            }
            catch (PostgresException ex)
            {
                errorMessage = $"Error de autenticación o base de datos ({ex.SqlState}): {ex.MessageText}";
                return false;
            }
            catch (NpgsqlException)
            {
                errorMessage = "No se pudo conectar con el servidor de base de datos. Verifica tu conexión a internet o el estado del proveedor.";
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = $"Error inesperado al conectar: {ex.Message}";
                return false;
            }
        }
    }

    
}
