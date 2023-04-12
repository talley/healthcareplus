using DevExpress.XtraEditors;
using HCP.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HCP.Fr.Admin
{
    public partial class frAdminDashBoard : DevExpress.XtraEditors.XtraForm
    {
        string _email;

        public frAdminDashBoard(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void frAdminDashBoard_Load(object sender, EventArgs e)
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
            var sel = e.Node.Text;
            if(sel.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez choisir une valeur");
            }
            else
            {
                switch (sel)
                {
                    case "Ajouter Utilisateur":
                        var newUserUI = new frAdminAddUser(_email);
                        ShowFormInPanel(newUserUI,splitPanel2);
                        break;
                    case "Gestion Utilisateurs":
                        var UsersUI = new frAdminManageUsers(_email);
                        ShowFormInPanel(UsersUI, splitPanel2);
                        break;
                    case "Changer Statut Utilisateur":
                        var DisUsersUI = new frAdminDisableUser(_email);
                        ShowFormInPanel(DisUsersUI, splitPanel2);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}