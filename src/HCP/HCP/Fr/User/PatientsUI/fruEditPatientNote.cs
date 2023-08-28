using DevExpress.XtraEditors;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Fr.User.PatientsUI
{
    public partial class fruEditPatientNote : XtraForm
    {

        private Guid _patid;
        private string _email;
        private readonly bool _isnew;
        private readonly int _id;


        private IRepository<PatientsNotes> _patNoteRepos = new PatientNoteRepository();
        public fruEditPatientNote(Guid patid,int id, string email, bool isnew=false)
        {
            InitializeComponent();

            _patid = patid;
            _id=id;
            _email = email;
            _isnew = isnew;
        }


        private async void fruEditPatientNote_Load(object sender, EventArgs e)
        {
            if (_isnew)
            {
                this.Text = "Ajout d'une nouvelle note.";
            }
            else
            {
                this.Text = "Modification d'une nouvelle note.";
            }



        }
        public async Task<PatientsNotes> GetPatient_Note()
        {
            var results = await _patNoteRepos.GetAllAsync();
            var result = results.SingleOrDefault(x => x.PnId == _id);
            return result;
        }
        public async Task<List<PatientsNotes>> GetPatient_Notes(Guid PatId)
        {
            var results = new List<PatientsNotes>();
            var result = await _patNoteRepos.GetAllAsync();
            results = result.Where(x => x.Id == _patid).AsParallel().ToList();
            return results;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnupdateaddr_Click(object sender, EventArgs e)
        {
            var note = await GetPatient_Note();
            if (_isnew)
            {
                var new_note = new PatientsNotes
                {
                    ajouter_au = CommonHelpers.GetEuDate(),
                    ajouter_par = CommonHelpers.GetSystemUserName(_email),
                    Id = _patid,
                    Notes = txtnotes.Text,
                    PnId = 0,
                };
                var result1 = await _patNoteRepos.SaveOrUpdateAsync(new_note);
                if (result1 > 0)
                {
                    DevExpressFrHelper.DisplayMessage("La note du patient a été mise à jour..");
                    DisableEditButton();
                }
                else
                {
                    DevExpressFrHelper.DisplayMessage("La note du patient n'a pas été mise à jour.Veuillez réessayer.");
                }
            }
            else
            {
                var edit_note = new PatientsNotes
                {
                    ajouter_au = note.ajouter_au,
                    ajouter_par = note.ajouter_par,
                    Id = note.Id,
                    Notes = txtnotes.Text,
                    PnId = note.PnId,
                    modifier_au = CommonHelpers.GetEuDate(),
                    modifier_par = CommonHelpers.GetSystemUserName(_email)
                };
                var result2 = await _patNoteRepos.SaveOrUpdateAsync(edit_note);
                if (result2 > 0)
                {
                    DevExpressFrHelper.DisplayMessage("La note du patient a été mise à jour..");
                }
                else
                {
                    DevExpressFrHelper.DisplayMessage("La note du patient n'a pas été mise à jour.Veuillez réessayer.");
                }
            }
        }

        private void DisableEditButton()
        {
            btnupdateaddr.Enabled = false;
        }
    }
}