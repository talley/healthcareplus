using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Logging.Helpers
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
