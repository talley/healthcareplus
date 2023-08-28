// Ignore Spelling: Sql Initalize

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCP.Fr.Sync;

namespace HCP
{
    public static class SyncFrManager
    {
        public static void InitalizeSqlCeDatabase()
        {
            DatabaseCreator.CreateDdIfNotExist();
        }

        public static void InitalizeSqlCeTables()
        {
            ClientProvisioner.Start("PatientsScope");
        }
    }
}
