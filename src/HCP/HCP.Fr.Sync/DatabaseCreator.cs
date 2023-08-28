using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace HCP.Fr.Sync
{
    public static class DatabaseCreator
    {

        public static string DbSource()
        {
            var path1 = GetFolderPath(SpecialFolder.CommonApplicationData);
            var db_name = string.Concat(MachineName, ".sdf");
            var db = Path.Combine(path1, db_name);

            //System.ArgumentException: 'Keyword not supported: 'provider'.'
            //"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;DataSource= error above
            var db_source = string.Concat("DataSource=", db);
            return db_source;
        }

        public static string DbPath()
        {
            var path1 = GetFolderPath(SpecialFolder.CommonApplicationData);
            var db_name = string.Concat(MachineName, ".sdf");
            var db = Path.Combine(path1, db_name);
            return db;
        }

        public static bool CreateDdIfNotExist()
        {
            bool result = false;
            try
            {
                var connection = DbSource();
                var db_file = DbPath();
                if (!File.Exists(db_file))
                {
                    SqlCeEngine en = new SqlCeEngine(connection);
                    en.CreateDatabase();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
