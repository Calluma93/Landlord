using System.Configuration;

namespace Landlord.Helpers
{
    public static class ConfigHelper
    {
        public static string RootUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["RootUrl"];
            }
        }
    }
}