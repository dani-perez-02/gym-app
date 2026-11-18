using gym_app.Configuration;

namespace gym_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if  (!DatabaseConfig.TestConnection(out string error))
            {
                MessageBox.Show(
                    $"No es posible iniciar la aplicación:\n\n{error}",
                    "Error de Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Application.Run(new GymApp());
        }
    }
}