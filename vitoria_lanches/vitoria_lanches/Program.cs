namespace vitoria_lanches
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private const string localhost = "localhost";
        private const string usuario = "root";
        private const string senha = "root";
        private const string database = "bd_vitoria_lanches";

        public static string conexao=$"server={localhost}; user_id={usuario}; password{senha}; database{database}";
    

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new inicio());
        }
    }
}