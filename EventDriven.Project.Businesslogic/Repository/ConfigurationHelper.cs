using System.Configuration;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            return "Data Source=KOUTAIBA;Initial Catalog=STEF;Integrated Security=True;TrustServerCertificate=True";
            //return ConfigurationManager.ConnectionStrings["Shane"]?.ConnectionString;
        }
    }
}
