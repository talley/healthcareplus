using System;
using System.Net.Mail;
using Config = System.Configuration.ConfigurationManager;
namespace HCP.Helpers
{
    public static class ApplicationHelper
    {
        public static string GetAppSettingValue(string key)
        {
            return Config.AppSettings[key];
        }

        public static string GetConnectionStringValue(string key)
        {
            return Config.ConnectionStrings[key].ConnectionString;
        }

        public static bool IsEmailValid(this string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
