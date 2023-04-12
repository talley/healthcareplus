using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HCP.Fr.Dao.Repository
{
    public static class UserCustom
    {
        internal static HcpFrEntities db = new HcpFrEntities();
        public static byte[] GetHashPassword(string password)
        {
            byte[] result=null;
            var sql = $"SELECT dbo.func_hash_password('{password}')";
             using(IDbConnection sqlcon=new SqlConnection(db.Database.Connection.ConnectionString)) {


                var tresult = sqlcon.ExecuteScalar(sql);
                result = (byte[])tresult;
            }
            return result;
        }

        public static async Task<byte[]> GetHashPasswordAsync(string password)
        {
            byte[] result = null;
            var sql = $"SELECT dbo.func_hash_password('{password}')";
            using (IDbConnection sqlcon = new SqlConnection(db.Database.Connection.ConnectionString))
            {


                var tresult =await sqlcon.ExecuteScalarAsync(sql).ConfigureAwait(false);
                result = (byte[])tresult;
            }
            return result;
        }
    }
}
