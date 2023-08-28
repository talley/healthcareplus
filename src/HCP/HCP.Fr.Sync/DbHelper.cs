using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Sync
{
    public static class DbHelper
    {
        public static string CS()
        {
            return @"data source=.;initial catalog=HCPFR;persist security info=True;user id=app_user;password=Iamsmart27!";
        }
    }
}
