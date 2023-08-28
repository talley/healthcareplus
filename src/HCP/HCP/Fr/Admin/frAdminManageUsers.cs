using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HCP.Fr.Admin
{
    public partial class frAdminManageUsers : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _email;
        private IRepository<UserStatuses> _userstatusesRepos = new UserStatusesRepository();
        private IRepository<Roles> _rolesRepos = new RoleRepository();
        private IRepository<Users> _usersRepos = new UserRepository();
        public frAdminManageUsers(string email)
        {
            InitializeComponent();
            _email = email;
          //  gridView1.FocusedRowObjectChanged += GridView1_FocusedRowObjectChanged;
        }

        //private void GridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        //{
        //    var data = e.Row;

        //}

        private async void frAdminManageUsers_Load(object sender, EventArgs e)
        {
            var users = await _usersRepos.GetAllAsync();
            var neededUsers = users.Select(x =>new
            {
                x.Id,
                x.email,
                x.Nom,
                x.prénom,
                x.nom_role,
                x.Statut,
                x.notes,
                x.ajouter_au,
                x.ajouter_par,
                x.modifier_au,
                x.modifier_par
            }).AsParallel().ToList();

            gridControl1.DataSource = neededUsers;




        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            gridControl1.Print();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            GridView view=gridControl1.MainView as GridView;
            if(view != null)
            {
                var pdfDir = PathsHelper.DebugPath() + "\\temp";
                if (!Directory.Exists(pdfDir))
                {
                    Directory.CreateDirectory(pdfDir);
                }
                var pdfPath = Path.Combine(pdfDir, "GestionUtilisateurs.pdf");
                if (File.Exists(pdfPath))
                {
                    File.Delete(pdfPath);
                }
                view.ExportToPdf(pdfPath);
                System.Diagnostics.Process.Start(pdfPath);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            GridView view = gridControl1.MainView as GridView;
            if (view != null)
            {
                var excelDir = PathsHelper.DebugPath() + "\\temp";
                if (!Directory.Exists(excelDir))
                {
                    Directory.CreateDirectory(excelDir);
                }
                var excelPath = Path.Combine(excelDir, "GestionUtilisateurs.xlsx");
                if (File.Exists(excelPath))
                {
                    File.Delete(excelPath);
                }
                view.ExportToXlsx(excelPath);
                System.Diagnostics.Process.Start(excelPath);
            }
        }

        private void btncsv_Click(object sender, EventArgs e)
        {
            GridView view = gridControl1.MainView as GridView;
            if (view != null)
            {
                var excelDir = PathsHelper.DebugPath() + "\\temp";
                if (!Directory.Exists(excelDir))
                {
                    Directory.CreateDirectory(excelDir);
                }
                var excelPath = Path.Combine(excelDir, "GestionUtilisateurs.csv");
                if (File.Exists(excelPath))
                {
                    File.Delete(excelPath);
                }
                view.ExportToCsv(excelPath);
                System.Diagnostics.Process.Start(excelPath);
            }
        }

        private void btnhtml_Click(object sender, EventArgs e)
        {
            GridView view = gridControl1.MainView as GridView;
            if (view != null)
            {
                var htmlDir = PathsHelper.DebugPath() + "\\temp";
                if (!Directory.Exists(htmlDir))
                {
                    Directory.CreateDirectory(htmlDir);
                }
                var htmlPath = Path.Combine(htmlDir, "GestionUtilisateurs.html");
                if (File.Exists(htmlPath))
                {
                    File.Delete(htmlPath);
                }
                view.ExportToHtml(htmlPath);
                System.Diagnostics.Process.Start(htmlPath);
            }
        }

        private void btnword_Click(object sender, EventArgs e)
        {
            GridView view = gridControl1.MainView as GridView;
            if (view != null)
            {
                var wDir = PathsHelper.DebugPath() + "\\temp";
                if (!Directory.Exists(wDir))
                {
                    Directory.CreateDirectory(wDir);
                }
                var wPath = Path.Combine(wDir, "GestionUtilisateurs.docx");
                if (File.Exists(wPath))
                {
                    File.Delete(wPath);
                }
                view.ExportToDocx(wPath);
                System.Diagnostics.Process.Start(wPath);
            }
        }

        private void btnrtf_Click(object sender, EventArgs e)
        {
            GridView view = gridControl1.MainView as GridView;
            if (view != null)
            {
                var rDir = PathsHelper.DebugPath() + "\\temp";
                if (!Directory.Exists(rDir))
                {
                    Directory.CreateDirectory(rDir);
                }
                var rPath = Path.Combine(rDir, "GestionUtilisateurs.rtf");
                if (File.Exists(rPath))
                {
                    File.Delete(rPath);
                }
                view.ExportToRtf(rPath);
                System.Diagnostics.Process.Start(rPath);
            }
        }
        //handle double click here
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            Guid Id = Guid.Parse(gridView1.GetRowCellValue(e.RowHandle, "Id").ToString());
            var user = _usersRepos.GetById(new Users { Id = Id });
            if (user != null)
            {

                var editForm = new frAdminEditUser(_email, user);
                editForm.ShowDialog();
            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            string statut = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "Statut"));

            if (statut =="InaActif")
            {
                e.Appearance.BackColor = Color.OrangeRed;
            }
            else
            {
               e.Appearance.BackColor = Color.LightGreen;
            }

            //Override any other formatting
            e.HighPriority = true;
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            Guid Id = Guid.Parse(gridView1.GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
            }
        }



        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            var user = e.Row as Users;
            if (user != null) {

                var editForm = new frAdminEditUser(_email,user);
                editForm.ShowDialog();
            }
        }
    }
}