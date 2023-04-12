using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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