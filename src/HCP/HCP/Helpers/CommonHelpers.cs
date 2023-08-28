using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace HCP.Helpers
{
    public static class CommonHelpers
    {
        public static string GetEuDate()
        {
            //DateTime.Now.ToString("MM/dd/yyyy")
            var today =DateTime.Now;
            var eudate = today.ToString("dd/MM/yyyy");
            return eudate;
        }
        public static string GetSystemUserName(string email ="")
        {
            string result = "";
            if (email.Length == 0)
            {
                result= Environment.MachineName;
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

        public static List<string> GetAvailabeSsns()
        {
            IEnumerable<string> ssns=new List<string>();
            var query = "SELECT Ssn from SecuritySsn";
            try
            {
               using(IDbConnection sqlcon=new SqlConnection(ConnectionHelper.CS()))
                {
                    ssns=sqlcon.Query<string>(query);
                }
            }
            catch (Exception ex)when(ex!=null)
            {

                throw ex;
            }

            return ssns.ToList();

        }

        public  static string GenerateSsn()
        {
           var ssns ="";
            var query = "SELECT dbo.func_gen_ssn()";
            try
            {
                using (IDbConnection sqlcon = new SqlConnection(ConnectionHelper.CS()))
                {
                    ssns = (string)sqlcon.ExecuteScalar(query);
                }
            }
            catch (Exception ex) when (ex != null)
            {

                throw ex;
            }

            return ssns;//SELECT dbo.func_ssn_exist('111-11-1111')
        }

        public static bool SsnExist(string ssn)
        {
            var result = false;
            var query = $"SELECT dbo.func_ssn_exist('{ssn}')";
            try
            {
                using (IDbConnection sqlcon = new SqlConnection(ConnectionHelper.CS()))
                {
                    var issns = int.Parse(sqlcon.ExecuteScalar(query).ToString());
                    if(issns > 0 )
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch (Exception ex) when (ex != null)
            {

                throw ex;
            }

            return result;//
        }
    }
}
