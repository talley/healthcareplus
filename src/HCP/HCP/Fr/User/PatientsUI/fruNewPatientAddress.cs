using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Helpers;
using System;
using System.Data;
using System.Linq;

namespace HCP.Fr.User.PatientsUI
{
    public partial class fruNewPatientAddress : XtraForm
    {
        private Guid _id;
        private string _email;
        private IRepository<Patient_Addresses> _patAddressesRepos = new PatientAddressRepository();
        public fruNewPatientAddress(Guid id, string email)
        {
            InitializeComponent();
            _id = id;
            _email = email;
        }

        private async void fruNewPatientAddress_Load(object sender, EventArgs e)
        {
            var patAddresses = await _patAddressesRepos.GetAllAsync();
            var patadd=patAddresses.OrderByDescending(x=>DateTime.Parse(x.ajouter_au)).Take(1).SingleOrDefault(x=> x.Id == _id);
            lock (patadd)
            {
                txtaddr.Text = patadd.adresse;
                txtapartment.Text = patadd.appartement;
                txtstate.Text = patadd.état_ou_région;
                drpcountries.SelectedText = patadd.Pays;
                txtzip.Text = patadd.boite_postale;
                txttelephone.Text = patadd.téléphone;
                txtnotes.Text = patadd.Notes;
                txtcity.Text = patadd.ville;
            }

            var countries = await ReadOnlyDataRepository.GetCountriesAsync();
            drpcountries.Properties.DataSource = countries.Select(x => new { x.Nom, x.Code2, x.Code3 }).ToList();
            drpcountries.Properties.DisplayMember = "Nom";
            drpcountries.Properties.ValueMember = "Nom";
            BestFitLookupEdit(drpcountries);

        }
        private void BestFitLookupEdit(LookUpEdit lookupctrl)
        {
            lookupctrl.Properties.BestFit();
            int width = 0;
            foreach (LookUpColumnInfo column in lookupctrl.Properties.Columns)
                width += column.Width;
            lookupctrl.Properties.PopupWidth = width + 4;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnupdateaddr_Click(object sender, EventArgs e)
        {
            var new_addr = txtaddr.Text;
            var new_apt=txtapartment.Text;
            var new_city=txtcity.Text;
            var new_state=txtstate.Text;
            var new_country = drpcountries.Text;
            var new_zip=txtzip.Text;
            var new_telephone=txttelephone.Text;
            var new_notes=txtnotes.Text;

            if(new_addr.Length==0 || new_apt.Length==0 || new_city.Length==0 ||
                new_state.Length==0 || new_country.Length==0 || new_zip.Length==0 ||
                new_telephone.Length==0 || new_notes.Length==0)
            {
                DevExpressFrHelper.DisplayMessage("Tous les champs sont obligatoires.");
            }
            else
            {
                var addr = new Patient_Addresses
                {
                    Id = _id,
                    adresse = new_addr,
                    ajouter_au = CommonHelpers.GetEuDate(),
                    ajouter_par = CommonHelpers.GetSystemUserName(_email),
                    appartement = new_apt,
                    boite_postale = new_zip,
                    Notes = new_notes,
                    PadId = 0,
                    Pays = new_country,
                    téléphone = new_telephone,
                    ville = new_city,
                    état_ou_région = new_state
                };
                var result= await _patAddressesRepos.SaveOrUpdateAsync(addr);
                if (result > 0)
                {
                    DevExpressFrHelper.DisplayMessage("Une nouvelle adresse de patient a été ajoutée.");
                    btnupdateaddr.Enabled = false;
                }
            }
        }
    }
}