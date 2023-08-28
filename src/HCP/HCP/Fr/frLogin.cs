using System;

namespace HCP.Fr
{
    public partial class frLogin : DevExpress.XtraEditors.XtraForm
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            var title = "Bienvenu a HCP";
            this.Text = title;
        }
    }
}