using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HCP.Fr.User
{
    public partial class FruDashBoard : XtraForm
    {
        private readonly string _email;
        public FruDashBoard(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void FruDashBoard_Load(object sender, EventArgs e)
        {

        }
        private void ShowFormInPanel(XtraForm frm, SplitPanel panel)
        {
            frm.TopLevel = false;
            foreach (Control ctr in panel.Controls)
            {
                if (ctr != frm)
                    ctr.Visible = false;
            }
            if (!panel.Controls.Contains(frm))
            {
                panel.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                frm.Visible = true;
            }
        }
        private void ShowFormInPanel(RadForm frm, SplitPanel panel)
        {
            frm.TopLevel = false;
            foreach (Control ctr in panel.Controls)
            {
                if (ctr != frm)
                    ctr.Visible = false;
            }
            if (!panel.Controls.Contains(frm))
            {
                panel.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                frm.Visible = true;
            }
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            var nodeText=e.Node.Text;
            switch (nodeText)
            {
                case "Nouveau Patient":
                    ShowFormInPanel(new fruNewPatient(_email), splitPanel2);
                    break;
                default:
                    break;
            }
        }
    }
}