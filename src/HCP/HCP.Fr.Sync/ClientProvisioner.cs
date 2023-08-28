using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;
using Microsoft.Synchronization.Data.SqlServerCe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace HCP.Fr.Sync
{
    public static class ClientProvisioner
    {
        public static void Start(string scopeName)
        {
            if (!ScopeExists("PatientsScope"))
            {
                // create a connection to the SyncCompactDB database
                //@"Data Source='C:\temp\SyncCompactDB.sdf'"
                SqlCeConnection clientConn = new SqlCeConnection(DatabaseCreator.DbSource());

                // create a connection to the SyncDB server database
                //"Data Source=localhost; Initial Catalog=SyncDB; Integrated Security=True"
                SqlConnection serverConn = new SqlConnection(DbHelper.CS());

                // get the description of ProductsScope from the SyncDB server database
                DbSyncScopeDescription scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope(scopeName, serverConn);

                // create CE provisioning object based on the ProductsScope
                SqlCeSyncScopeProvisioning clientProvision = new SqlCeSyncScopeProvisioning(clientConn, scopeDesc);

                // starts the provisioning process
                clientProvision.Apply();
            }
        }

        public static void Start()
        {
            if (!ScopeExists("PatientsScope"))
            {
                // create a connection to the SyncCompactDB database
                //@"Data Source='C:\temp\SyncCompactDB.sdf'"
                SqlCeConnection clientConn = new SqlCeConnection(DatabaseCreator.DbSource());

                // create a connection to the SyncDB server database
                //"Data Source=localhost; Initial Catalog=SyncDB; Integrated Security=True"
                SqlConnection serverConn = new SqlConnection(DbHelper.CS());

                // get the description of ProductsScope from the SyncDB server database
                DbSyncScopeDescription scopeDesc = SqlSyncDescriptionBuilder.GetDescriptionForScope("PatientsScope", serverConn);

                // create CE provisioning object based on the ProductsScope
                SqlCeSyncScopeProvisioning clientProvision = new SqlCeSyncScopeProvisioning(clientConn, scopeDesc);

                // starts the provisioning process
                clientProvision.Apply();
            }
        }

        public static bool ScopeExists(string scopeName)
        {
            var result = false;
            var cs = DatabaseCreator.DbSource();
            var query = $"SELECT COUNT(*) as result FROM scope_info WHERE sync_scope_name='{scopeName}'";
            using (IDbConnection sqlcon = new SqlCeConnection(cs))
            {
                try
                {
                    var x = sqlcon.Query(query);
                    if (x != null)
                    {
                        result = true;
                    }
                    else { result = false; }
                }
                catch (Exception ex)
                {

                    result |= false;
                }


            }


            return result;
        }
    }
}
