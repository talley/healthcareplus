using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Helpers
{
    public static class DevExpressFrHelper
    {

        public static void DisplayErrorMessage(string field)
        {
            XtraMessageBox.Show(string.Concat("Entrez s'il vous plait: ", field), "HCP", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public static void DisplayMessage(string message)
        {
            XtraMessageBox.Show(message, "HCP", System.Windows.Forms.MessageBoxButtons.OK);
        }

        internal static void ChooseValue()
        {
            XtraMessageBox.Show("Veuillez choisir la valeur", "HCP", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
