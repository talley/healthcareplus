using AutoMapper;
using DevExpress.LookAndFeel;
using HCP.Fr.Admin;
using HCP.Fr.Mappings;
using HCP.Fr.Sync;
using HCP.Fr.User.PatientsUI;
using HCP.Helpers;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
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
            //fr
            MapperConfiguration mp;
            AutoMapperMapper.Configure(out mp);

            var lang = ApplicationHelper.GetAppSettingValue("sys_lang");
            if (Thread.CurrentThread.CurrentCulture.Name != "fr-FR")
            {
                // If current culture is not fr-FR, set culture to fr-FR.
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("fr-FR");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr-FR");
            }
            else
            {
                // Set culture to en-US.
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            }

            Application.EnableVisualStyles();
            // DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");

            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2013);
            Application.SetCompatibleTextRenderingDefault(false);
            if (lang == "fr")
            {
                if (!ServerProvisioner.ScopeExists("PatientsScope"))
                {
                    ServerProvisioner.Start(scopeName: "PatientsScope", tableName: "Patients");
                }

                if (File.Exists(DatabaseCreator.DbPath()))
                {
                    SyncFrManager.InitalizeSqlCeDatabase();
                    SyncFrManager.InitalizeSqlCeTables();
                    ClientProvisioner.Start("PatientsScope");
                }


                Application.Run(new fruPatientsManagement("talleyouro@outlook.com"));
            }
            else
            {
                Application.Run(new Form1());
            }

        }
    }
}
