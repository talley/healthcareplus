using System;
using System.Text;

namespace HCP.Fr
{
    public partial class ErrorManager : DevExpress.XtraEditors.XtraForm
    {
        private Exception _exception;
        public ErrorManager(Exception exception)
        {
            InitializeComponent();
            _exception = exception;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ErrorManager_Load(object sender, EventArgs e)
        {
            var error=new StringBuilder();
            if(_exception != null)
            {
                error.Append("========================Détail de l'exception================="+Environment.NewLine);
                error.Append(_exception.Message);

                if(_exception.InnerException != null)
                {
                    error.Append("========================Détail de l'exception================="+Environment.NewLine);
                    error.Append(_exception.InnerException.Message);

                }
            }
        }
    }
}