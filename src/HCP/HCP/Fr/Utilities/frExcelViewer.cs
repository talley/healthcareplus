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

namespace HCP.Fr.Utilities
{
    public partial class frExcelViewer : DevExpress.XtraEditors.XtraForm
    {
        string _email;
        public frExcelViewer(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void frExcelViewer_Load(object sender, EventArgs e)
        {

            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var excel_file = openFileDialog1.FileName;
                spreadsheetControl1.LoadDocument(excel_file);
            }
        }
    }
}