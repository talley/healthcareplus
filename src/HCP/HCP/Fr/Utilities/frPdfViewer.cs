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
    public partial class frPdfViewer : DevExpress.XtraEditors.XtraForm
    {
        string _email;
        public frPdfViewer(string email)
        {
            InitializeComponent();
            _email = email;
        }
    }
}