using System;

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
