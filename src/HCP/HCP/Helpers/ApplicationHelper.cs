using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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
