using DevExpress.XtraEditors;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Helpers;
using System;
using HCP.Fr.Logging;
namespace HCP.Fr.User.PatientsUI
{
    public partial class fruNewPatientRaisonVisite : XtraForm
    {

        readonly string _email;
        private Guid _id;
        // private ReadOnyDataRepository
        private IRepository<Patients> _patRepos = new PatientRepository();
        private IRepository<PatientsNotes> _patNote_Repos = new PatientNoteRepository();
        private IRepository<PatientsVisitNotes> _patVisitNoteRepos = new PatientVisitNoteRepository();
        private IRepository<Patient_Addresses> _patAddressesRepos = new PatientAddressRepository();
        private IRepository<SecuritySsn> ssnrepo = new PatientSsnRepository();
        public fruNewPatientRaisonVisite(string email,Guid id)
        {
            InitializeComponent();
            _email = email;
            _id = id;
        }
        private void fruNewPatientRaisonVisite_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                var patId = _id;
                var email = _email;
                var raison = txtvisitraison.Text;
                if (raison.Length == 0)
                {
                    DevExpressFrHelper.DisplayMessage("Veuillez entrer la raison de la visite.");
                }
                else
                {
                    var data = new PatientsVisitNotes
                    {
                        ajouter_au = CommonHelpers.GetEuDate(),
                        ajouter_par = CommonHelpers.GetSystemUserName(_email),
                        Id = patId,
                        Notes = raison,
                        PvId = 0
                    };

                    var result = await _patVisitNoteRepos.SaveOrUpdateAsync(data);
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("La raison patiente de la visite a été ajoutée.");
                        btnadd.Enabled = false;
                    }
                    else
                    {
                        DevExpressFrHelper.DisplayMessage("La raison patiente de la visite n`a pas été ajoutée.");
                    }
                }
            }
            catch (Exception ex)
            {
                ex.LogToDb("btnadd_Click", "fruNewPatientRaisonVisite.cs", _email);
            }
        }
    }
}