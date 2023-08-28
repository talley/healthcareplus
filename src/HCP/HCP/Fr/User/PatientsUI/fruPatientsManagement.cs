using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Fr.Helpers;
using HCP.Helpers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace HCP.Fr.User.PatientsUI
{
    public partial class fruPatientsManagement : DevExpress.XtraEditors.XtraForm
    {

        readonly string _email;
        // private ReadOnyDataRepository
        private IRepository<Patients> _patRepos = new PatientRepository();
        private IRepository<PatientsNotes> _patNote_Repos = new PatientNoteRepository();
        private IRepository<PatientsVisitNotes> _patVisitNoteRepos = new PatientVisitNoteRepository();
        private IRepository<Patient_Addresses> _patAddressesRepos = new PatientAddressRepository();
        private IRepository<SecuritySsn> ssnrepo = new PatientSsnRepository();
        public fruPatientsManagement(string email)
        {
            InitializeComponent();
            _email = email;
        }


        private async void fruPatientsManagement_Load(object sender, EventArgs e)
        {
            this.Text = "Gestion Des Patients";

            var patientSearchColumns= PatientHelpers.GetPatientSearchColumns();
            foreach (var pat in patientSearchColumns)
            {
                drpcriterias.Properties.Items.Add(pat.colonne);
            }
            var patients=await _patRepos.GetAllAsync();
           var needed_patients=(from p in patients
                               orderby p.nom ascending
                               select new
                               {
                                   p.Id,p.ssn_ou_identité,p.nom,p.prénom,p.date_naissance,p.genre,
                                   p.adresse,p.ville,p.appartement,p.état_ou_région,
                                   p.boite_postale,p.Pays,p.téléphone,p.email,p.statut
                               }).ToList();
            gridControl1.DataSource=needed_patients;

            gridView1.Columns["Id"].Visible = false;
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            //if (e.RowHandle == view.FocusedRowHandle) return;
            if (e.Column.FieldName != "Statut") return;
            // Fill a cell's background if its value is greater than 30.
            if (e.CellValue.ToString() == "Actif")
            {
                e.Appearance.BackColor = Color.FromArgb(60, Color.Green);
            }
            else
            {
                e.Appearance.BackColor = Color.FromArgb(60, Color.Red);
            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            gridControl1.Print();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            try
            {
                var pdf = Path.Combine(Path.GetTempPath(), string.Concat(Environment.MachineName, ".pdf"));
                if (File.Exists(pdf))
                {
                    File.Delete(pdf);
                }
                GridView View = gridControl1.MainView as GridView;
                if (View != null)
                {
                    View.OptionsPrint.ExpandAllDetails = true;
                    View.ExportToPdf(pdf);
                }
                Process.Start(pdf);
            }
            catch (Exception ex)
            {

                DevExpressFrHelper.DisplayMessage("Ce fichier est déjà ouvert dans Adobe Reader.Veuillez le fermer.");
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            try
            {
                var excel = Path.Combine(Path.GetTempPath(), string.Concat(Environment.MachineName, ".xlxs"));

                if (File.Exists(excel))
                {
                    File.Delete(excel);
                }

                GridView View = gridControl1.MainView as GridView;

                if (View != null)
                {
                    View.OptionsPrint.ExpandAllDetails = true;
                    View.ExportToXlsx(excel);
                }
                Process.Start(excel);
            }
            catch (Exception ex)
            {

                DevExpressFrHelper.DisplayMessage("Ce fichier est déjà ouvert dans Excel.Veuillez le fermer.");
            }
        }

        private void btnword_Click(object sender, EventArgs e)
        {
            var word = Path.Combine(Path.GetTempPath(), string.Concat(Environment.MachineName, ".docx"));
            try
            {

                if (File.Exists(word))
                {
                    File.Delete(word);
                }

                GridView View = gridControl1.MainView as GridView;

                if (View != null)
                {
                    View.OptionsPrint.ExpandAllDetails = true;
                    View.ExportToDocx(word);
                }
                Process.Start(word);
            }
            catch (Exception ex)
            {
              // var locks= ProcessManager.GetProcessesLockingFile(word);
               //var lock2= ProcessManager.GetFilesLockedBy(locks.FirstOrDefault());
               DevExpressFrHelper.DisplayMessage("Ce fichier est déjà ouvert dans Word.Veuillez le fermer.");
            }
        }

        private void btnhtml_Click(object sender, EventArgs e)
        {
            var word = Path.Combine(Path.GetTempPath(), string.Concat(Environment.MachineName, ".html"));
            try
            {

                if (File.Exists(word))
                {
                    File.Delete(word);
                }

                GridView View = gridControl1.MainView as GridView;

                if (View != null)
                {
                    View.OptionsPrint.ExpandAllDetails = true;
                    View.ExportToHtml(word);
                }
                Process.Start(word);
            }
            catch (Exception ex)
            {
                DevExpressFrHelper.DisplayMessage("Ce fichier est déjà ouvert dans Word.Veuillez le fermer.");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            var term=drpcriterias.Text.Trim();
            var valeur=txtvalue.Text.Trim();
            if(term.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez choisir un critère.");
            }
            else if(valeur.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez entrer la valeur du critère.");
            }
            else
            {
                var searchResult=PatientHelpers.PatientSearch(term, valeur);
                if (searchResult != null)
                {
                    gridControl1.DataBindings.Clear();
                    gridControl1.DataSource = searchResult;
                }
                else
                {
                    DevExpressFrHelper.DisplayMessage("La recherche n'a donné aucun résultat.");

                }
            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            /*string statut = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "Statut"));

            if (statut == "InActif")
            {
                e.Appearance.BackColor = Color.Red;
            }
            else
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            e.HighPriority = true;
            */
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "statut")
            {
                string value = Convert.ToString(currentView.GetRowCellValue(e.RowHandle, "statut"));
                if (value == "Actif")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
                else
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                }

            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);
            if ((info.InRow || info.InRowCell) &  info.Column != null)
	        {
                var grid = sender as GridView;
                Object cellValue = view.GetRowCellValue(info.RowHandle, info.Column);
                //MessageBox.Show(string.Format("Made a doubleclick at rowhandle: {0}, columnhandle: {1}, value: {2}.",
                //    info.RowHandle, info.Column.ColumnHandle, cellValue));
                    dynamic selected_row = grid.GetRow(info.RowHandle);
                   if (selected_row != null)
                   {
                        new fruEditPatient(selected_row.Id, "test@test.com").ShowDialog();
                    }
            }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {

        }
    }
}