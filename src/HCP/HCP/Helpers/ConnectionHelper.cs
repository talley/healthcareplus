using Config = System.Configuration.ConfigurationManager;

namespace HCP.Helpers
{
    public static class ConnectionHelper
    {
        public static string CS()
        {
            return Config.ConnectionStrings["db_01"].ConnectionString;
        }
    }
}
