using Microsoft.Synchronization.Data.SqlServer;
using Microsoft.Synchronization.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace HCP.Fr.Sync
{
    public static class ServerProvisioner
    {
        public static void Start()
        {
            //"Data Source=localhost; Initial Catalog=SyncDB; Integrated Security=True"
            SqlConnection serverConn = new SqlConnection(DbHelper.CS());

            // define a new scope named ProductsScope
            DbSyncScopeDescription scopeDesc = new DbSyncScopeDescription("PatientsScope");
            // get the description of the Products table from SyncDB database
            DbSyncTableDescription tableDesc = SqlSyncDescriptionBuilder.GetDescriptionForTable("Patients", serverConn);

            // add the table description to the sync scope definition
            scopeDesc.Tables.Add(tableDesc);

            // create a server scope provisioning object based on the ProductScope
            SqlSyncScopeProvisioning serverProvision = new SqlSyncScopeProvisioning(serverConn, scopeDesc);

            // skipping the creation of table since table already exists on server
            serverProvision.SetCreateTableDefault(DbSyncCreationOption.Skip);

            // start the provisioning process
            serverProvision.Apply();
        }

        public static void Start(string scopeName, string tableName)
        {

            if (!ScopeExists(scopeName))
            {
                //"Data Source=localhost; Initial Catalog=SyncDB; Integrated Security=True"
                SqlConnection serverConn = new SqlConnection(DbHelper.CS());

                // define a new scope named ProductsScope
                DbSyncScopeDescription scopeDesc = new DbSyncScopeDescription(scopeName);
                // get the description of the Products table from SyncDB database
                DbSyncTableDescription tableDesc = SqlSyncDescriptionBuilder.GetDescriptionForTable(tableName, serverConn);

                // add the table description to the sync scope definition
                scopeDesc.Tables.Add(tableDesc);

                // create a server scope provisioning object based on the ProductScope
                SqlSyncScopeProvisioning serverProvision = new SqlSyncScopeProvisioning(serverConn, scopeDesc);

                // skipping the creation of table since table already exists on server
                serverProvision.SetCreateTableDefault(DbSyncCreationOption.Skip);

                // start the provisioning process
                serverProvision.Apply();
            }
        }

        public static bool ScopeExists(string scopeName)
        {
            var result = false;
            var query = $"SELECT COUNT(*) as result FROM scope_info WHERE sync_scope_name='{scopeName}'";
            using (IDbConnection sqlcon = new SqlConnection(DbHelper.CS()))
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
                catch (Exception)
                {

                    result = false;
                }

            }


            return result;
        }
    }
}
