using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Helpers
{
    public static class PathsHelper
    {
        public static string DebugPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
