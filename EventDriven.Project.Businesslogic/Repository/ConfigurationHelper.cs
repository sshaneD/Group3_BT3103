using System.Configuration;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
           
            switch (Environment.MachineName)
            {
                case "KOUTAIBA":
                    return ConfigurationManager.ConnectionStrings["KOUTAIBA"].ConnectionString;
                case "JACE":
                    return ConfigurationManager.ConnectionStrings["JACE"].ConnectionString;
                default:
                    return null;
            }
        }
    }
}