using DevExpress.XtraEditors;
using HCP.Fr.Admin.SpecialitiesUI;
using HCP.Fr.Utilities;
using HCP.Helpers;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HCP.Fr.Admin
{
    public partial class frAdminDashBoard : XtraForm
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
        private void ShowFormInPanel(XtraForm frm, Panel panel)
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
            if (sel.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez choisir une valeur");
            }
            else
            {
                switch (sel)
                {
                    case "Ajouter Utilisateur":
                        var newUserUI = new frAdminAddUser(_email);
                        ShowFormInPanel(newUserUI, splitPanel2);
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

        private void kryptonTreeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var sel = e.Node.Text;
            if (sel.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez choisir une valeur");
            }
            else
            {
                switch (sel)
                {
                    case "Ajouter Utilisateur":
                        var newUserUI = new frAdminAddUser(_email);
                        ShowFormInPanel(newUserUI, splitPanel2);
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

        private void kryptonTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var sel = e.Node.Text;
            if (sel.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez choisir une valeur");
            }
            else
            {
                switch (sel)
                {
                    case "Importer Sous-Spécialité":
                        var subspImportUI = new fruImportSubSpecialities(_email);
                        ShowFormInPanel(subspImportUI, splitPanel2);
                        break;
                    case "Gestion Des Sous-Spécialités":
                        var subspsUI = new fruAdminSubSpecialities(_email);
                        ShowFormInPanel(subspsUI, splitPanel2);
                        break;
                    case "Importation Des Spécialités":
                        var spsImptUI = new fruAdminImportSpecialities(_email);
                        ShowFormInPanel(spsImptUI, splitPanel2);
                        break;

                    default:
                        break;
                }
            }
        }

        private void kryptonTreeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //
            var sel = e.Node.Text;
            if (sel.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez choisir une valeur");
            }
            else
            {
                switch (sel)
                {
                    case "Séparateur PDF":
                        var subspImportUI = new fruPdfSplitter(_email);
                        ShowFormInPanel(subspImportUI, splitPanel2);
                        break;
                    case "Visionneuse Excel":
                        var subspsUI = new frExcelViewer(_email);
                        ShowFormInPanel(subspsUI, splitPanel2);
                        break;
                    case "Visionneuse PDF":
                        var spsImptUI = new frPdfViewer(_email);
                        ShowFormInPanel(spsImptUI, splitPanel2);
                        break;
                    case "Visionneuse Word":
                        var spsImptUI2 = new frWordViewer(_email);
                        ShowFormInPanel(spsImptUI2, splitPanel2);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}