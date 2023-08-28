using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using HCP.Helpers;

namespace HCP.Fr.Admin.SpecialitiesUI
{
    public partial class fruImportSubSpecialities : XtraForm
    {
        string _email;
        System.Diagnostics.Stopwatch sWatch = new System.Diagnostics.Stopwatch();
        public fruImportSubSpecialities(string email)
        {
            InitializeComponent();
            _email = email;
            // bw.DoWork += Bw_DoWork;

        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excel|*.xls;*.xlsx;";
            // od.FileName = "EmployeeList.xlsx";
            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.Abort)
                return;
            if (dr == DialogResult.Cancel)
                return;
            txtpath.Text = od.FileName.ToString();
            spreadsheetControl1.LoadDocument(txtpath.Text);
            btnupload.Visible = true;
        }

        private void fruImportSubSpecialities_Load(object sender, EventArgs e)
        {
            Text = "Importer des sous-spécialités";

            if (bw.IsBusy)
            {
                return;
            }
        }

        private void InsertSubSpecialitiesRecords()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConnectionHelper.CS());

                var _path = txtpath.Text.Trim();
                string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", _path);
                OleDbConnection Econ = new OleDbConnection(constr);
                string Query = string.Format("Select [Spécialité],[Sous_Spécialité],[Description],[Statut] FROM [{0}]", "Sheet1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();

                DataSet ds = new DataSet();
                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                Econ.Close();
                oda.Fill(ds);

                DataTable Exceldt = ds.Tables[0];

                for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
                {
                    if (Exceldt.Rows[i]["Spécialité"] == DBNull.Value || Exceldt.Rows[i]["Sous_Spécialité"] == DBNull.Value &&
                        Exceldt.Rows[i]["Description"] == DBNull.Value || Exceldt.Rows[i]["Statut"] == DBNull.Value
                        )
                    {
                        Exceldt.Rows[i].Delete();
                    }
                    else if (Exceldt.Rows[i]["Sous_Spécialité"] != DBNull.Value)
                    {
                        var spec = Exceldt.Rows[i]["Sous_Spécialité"].ToString();
                        if (SpecialityExists(spec))
                        {
                            DevExpressFrHelper.DisplayMessage("Cette Sous Spécialité existe déjà et sera supprimée.");
                            Exceldt.Rows[i].Delete();
                        }
                    }
                }


                Exceldt.AcceptChanges();
                //creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(sqlcon);

                //assigning Destination table name
                objbulk.DestinationTableName = "Sub_Specialties";
                //Mapping Table column
                objbulk.ColumnMappings.Add("[Spécialité]", "Spécialité");
                objbulk.ColumnMappings.Add("Sous_Spécialité", "Sous_Spécialité");
                objbulk.ColumnMappings.Add("Description", "Description");
                objbulk.ColumnMappings.Add("Statut", "Statut");


                sqlcon.Open();

                objbulk.WriteToServer(Exceldt);

                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }

                MessageBox.Show("Data has been Imported successfully.", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Data has not been Imported due to :{0}", ex.Message), "Not Imported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //progressBarControl1.Visible = false;
                txtpath.Text = "";
                btnbrowse.Enabled = true;
                //label1.Visible = false;
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            if (txtpath.Text.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez parcourir le fichier Excel à importer.");
            }
            else
            {
                InsertSubSpecialitiesRecords();
            }

        }

        private bool SpecialityExists(string spec)
        {
            var cs = ConnectionHelper.CS();
            int result = 0;
            var query = $"SELECT COUNT(*) Sub_Specialties FROM WHERE Sous_Spécialité='{spec}'";
            using (var sqlcon = new SqlConnection(cs))
            {
                sqlcon.Open();

                using (var sqlcmd = new SqlCommand(query, sqlcon))
                {
                    result = (int)sqlcmd.ExecuteScalar();
                }

                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return result > 0 ? true : false;
        }

        private async Task<bool> SpecialityExistsAsync(string spec)
        {
            var cs = ConnectionHelper.CS();
            int result = 0;
            var query = $"SELECT COUNT(*) Sub_Specialties FROM WHERE Sous_Spécialité='{spec}'";
            using (var sqlcon = new SqlConnection(cs))
            {
                sqlcon.Open();

                using (var sqlcmd = new SqlCommand(query, sqlcon))
                {
                    result = (int)await sqlcmd.ExecuteScalarAsync().ConfigureAwait(false);
                }

                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return result > 0 ? true : false;
        }
    }
}