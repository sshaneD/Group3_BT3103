using System.Configuration;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            return "Data Source=KOUTAIBA;Initial Catalog=STEF;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
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