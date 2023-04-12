using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using HCP.Fr;
using HCP.Fr.Admin;
using HCP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HCP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var lang = ApplicationHelper.GetAppSettingValue("sys_lang");

            Application.EnableVisualStyles();
           // ThemeManager.ApplicationThemeName = Theme.MetropolisLightName;
            Application.SetCompatibleTextRenderingDefault(false);
            if (lang == "fr")
            {
                Application.Run(new frAdminDashBoard("talleyouro@outlook.com"));
            }
            else
            {
                Application.Run(new Form1());
            }

        }
    }
}
