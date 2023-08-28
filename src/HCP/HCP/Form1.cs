using DevExpress.Xpo.DB.Helpers;
using HCP.Fr.Sync;

namespace HCP
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            var servercon = DbHelper.CS();
            var clientcon = DatabaseCreator.DbSource();
            var table = "Patients";
            //SqlCeDataSynchronizer.Synchronize(tableName, serverConnectionString, clientConnectionString);
        }
    }
}
