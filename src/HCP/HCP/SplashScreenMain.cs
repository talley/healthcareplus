using DevExpress.XtraSplashScreen;
using System;

namespace HCP
{
    public partial class SplashScreenMain : SplashScreen
    {
        public SplashScreenMain()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}