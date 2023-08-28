using System;

namespace HCP.Fr.Tests.Helpers
{
    public static class CommonHelpers
    {
        public static string GetEuDate()
        {
            //DateTime.Now.ToString("MM/dd/yyyy")
            var today = DateTime.Now;
            var eudate = today.ToString("dd/MM/yyyy");
            return eudate;
        }
        public static string GetSystemUserName(string email = "")
        {
            string result = "";
            if (email.Length == 0)
            {
                result = Environment.MachineName;
            }
            else
            {
                result = string.Concat(email, "@", Environment.MachineName);
            }

            return result;
        }

        public static string GetSystemUserName()
        {
            return Environment.UserDomainName;
        }
    }
}
