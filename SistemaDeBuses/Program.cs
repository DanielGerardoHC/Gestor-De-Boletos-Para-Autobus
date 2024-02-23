namespace SistemaDeBuses
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
            Login loginForm = new Login(null); // Pasa null o una referencia válida al formulario principal
            Application.Run(loginForm);
        }
    }
}