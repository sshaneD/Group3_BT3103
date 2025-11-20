using System.Globalization;

namespace EventDriven.Project.UI
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

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-PH");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-PH");

            FormLogin formLogin = new FormLogin();
            Application.Run(formLogin);
           
        }
    }
}