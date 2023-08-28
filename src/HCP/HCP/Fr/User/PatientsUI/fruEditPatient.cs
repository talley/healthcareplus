using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Card;
using HCP.Helpers;
using HCP.Fr.Logging;
using HCP.Fr.Helpers;
using System.IO;

namespace HCP.Fr.User.PatientsUI
{
    public partial class fruEditPatient : XtraForm
    {
        private Guid Id;
        readonly string _email;
        // private ReadOnyDataRepository
        private IRepository<Patients> _patRepos = new PatientRepository();
        private IRepository<PatientsNotes> _patNote_Repos = new PatientNoteRepository();
        private IRepository<PatientsVisitNotes> _patVisitNoteRepos = new PatientVisitNoteRepository();
        private IRepository<Patient_Addresses> _patAddressesRepos = new PatientAddressRepository();
        private IRepository<SecuritySsn> ssnrepo = new PatientSsnRepository();
        private IRepository<PatientIdentities> _patIdRepos = new PatientIdentitiesRepository();
        public fruEditPatient(Guid Id, string email)
        {
            InitializeComponent();
            this.Id = Id;
            this._email = email;
        }

        private async void fruEditPatient_Load(object sender, EventArgs e)
        {
            this.Text = $"Modification Du Patient:{Id}";
            try
            {
                this.Text = $"Modification du patient: {this.Id}";
                var countries = await ReadOnlyDataRepository.GetCountriesAsync();
                var genders = ReadOnlyDataRepository.GetGenders();

                drpcountries.Properties.DataSource = countries.Select(x => new { x.Nom, x.Code2, x.Code3 }).ToList();
                drpcountries.Properties.DisplayMember = "Nom";
                drpcountries.Properties.ValueMember = "Nom";
                BestFitLookupEdit(drpcountries);

                drpgenres.Properties.DataSource = genders;
                BestFitLookupEdit(drpgenres);

                var addresses = await GetPatient_Addresses(this.Id);
                var notes = await GetPatient_Notes(this.Id);
                var needed_addrs = (from a in addresses
                                    orderby a.ajouter_au descending
                                    select new
                                    {
                                        a.Id,
                                        a.PadId,
                                        a.adresse,
                                        a.appartement,
                                        a.boite_postale,
                                        a.ville,
                                        a.état_ou_région,
                                        a.Pays,
                                        a.téléphone,
                                        a.Notes,
                                        a.ajouter_au,
                                        a.ajouter_par
                                    }).ToList();
                grid_addresses.DataSource = needed_addrs;

                var last_address = needed_addrs.OrderByDescending(x => DateTime.Parse(x.ajouter_au))
                    .Take(1)
                    .SingleOrDefault();
                ;

                if (last_address != null)
                {
                    txtaddr.Text = last_address.adresse;
                    txtapartnumb.Text = last_address.appartement;
                    txtcity.Text = last_address.ville;
                    txtzip.Text = last_address.boite_postale;
                    txtregion.Text = last_address.état_ou_région;
                    drpcountries.Properties.NullText = last_address.Pays;
                    txttelephone2.Text = last_address.téléphone;
                    txtaddrId.Text = last_address.PadId.ToString();
                    txtaddr_ajouterau.Text = last_address.ajouter_au;
                    txtaddr_ajouterpar.Text = last_address.ajouter_par;
                    txtaddr_notes.Text = last_address.Notes;
                }
                var needed_notes = (from n in notes orderby n.ajouter_au descending select new { n.PnId, n.Notes }).ToList(
                    );
                gridnotes.DataSource = needed_notes;

                var visit_raisons = await _patVisitNoteRepos.GetAllAsync();
                var needed_visit_raisons = (from v in visit_raisons
                                            orderby v.ajouter_au descending
                                            select new { v.PvId, v.Notes }).ToList();
                grid_raisons_visits.DataSource = needed_visit_raisons;

                var last_raison_visit = visit_raisons.OrderByDescending(x => DateTime.Parse(x.ajouter_au)).Take(1);

                txtraisonvisite.Text = last_raison_visit.SingleOrDefault().Notes;

                var last_address2 = addresses.OrderByDescending(x => DateTime.Parse(x.ajouter_au))
                    .Take(1)
                    .SingleOrDefault();


                var patient = GetPatient(this.Id);
                if (patient != null)
                {
                    txtid.Text = patient.Id.ToString();
                    txtssn.Text = patient.ssn_ou_identité;
                    dtpublicationdate.Text = patient.Identité_date_de_publication;
                    txtlicense.Text = patient.numero_carte_identité;
                    dtexpirationdate.Text = patient.Identité_expiration;
                    txtlicaddress.Text = patient.adresse_carte_identité;
                    txtheight.Text = patient.taille;
                    txteyes.Text = patient.yeux;
                    txthair.Text = patient.cheveux;

                    txtlname.Text = patient.nom;
                    txtfname.Text = patient.prénom;
                    txtmiddle.Text = patient.deuxième_nom;
                    dtdob.Text = patient.date_naissance;
                    txtlieunaiss.Text = patient.lieux_naissance;
                    txtphone.Text = patient.téléphone;
                    txtfax.Text = patient.fax;
                    txtemail.Text = patient.email;

                    drpgenres.Properties.NullText = patient.genre;
                    //drpgenres.Update();

                    txtemployer.Text = patient.employeur;
                    txtlinkedin.Text = patient.linkedin;
                    txtwhatsapp.Text = patient.whatsapp;
                    txtwitter.Text = patient.twitter;
                }

                var patids = await _patIdRepos.GetAllAsync();
                if (patids != null)
                {
                    var needed_patids = (from p in patids
                                         orderby p.Type ascending
                                         select new
                                         {
                                             p.Id,
                                             p.Type,
                                             Extension = new FileInfo(p.Chemin_Du_Fichier).Extension
                                         }).ToList();
                    drpidentities.Properties.DataSource = needed_patids;
                    drpidentities.Properties.DisplayMember = "Type";
                    drpidentities.Properties.ValueMember = "Type";
                }
                else
                {
                    DevExpressFrHelper.DisplayMessage("Veuillez ajouter des types d'identité dans la base de données.");
                }
            }
            catch (Exception ex)
            {
                DevExpressFrHelper.DisplayMessage(ex.Message);
                ex.LogToDb("private async void fruEditPatient_Load", "fruEditPatient.cs", _email);
            }
        }

        private void BestFitLookupEdit(LookUpEdit lookupctrl)
        {
            lookupctrl.Properties.BestFit();
            int width = 0;
            foreach (LookUpColumnInfo column in lookupctrl.Properties.Columns)
                width += column.Width;
            lookupctrl.Properties.PopupWidth = width + 4;
        }

        public Patients GetPatient(Guid Id)
        {
            var result = new Patients();
            var patients = _patRepos.GetAll();
            var patient = patients.SingleOrDefault(x => x.Id == Id);
            result = patient;
            return result;
        }

        public async Task<Patients> GetPatientAsync(Guid Id)
        {
            var result = new Patients();
            var patients = await _patRepos.GetAllAsync();
            var patient = patients.SingleOrDefault(x => x.Id == Id);
            result = patient;
            return result;
        }

        public async Task<List<Patient_Addresses>> GetPatient_Addresses(Guid PatId)
        {
            var results = new List<Patient_Addresses>();
            var result = await _patAddressesRepos.GetAllAsync();
            results = result.Where(x => x.Id == PatId).AsParallel().ToList();
            return results;
        }

        public async Task<List<PatientsNotes>> GetPatient_Notes(Guid PatId)
        {
            var results = new List<PatientsNotes>();
            var result = await _patNote_Repos.GetAllAsync();
            results = result.Where(x => x.Id == PatId).AsParallel().ToList();
            return results;
        }

        public async Task<List<PatientsVisitNotes>> GetPatient_VisitNotes(Guid PatId)
        {
            var results = new List<PatientsVisitNotes>();
            var result = await _patVisitNoteRepos.GetAllAsync();
            results = result.Where(x => x.Id == PatId).AsParallel().ToList();
            return results;
        }

        private void btnnewaddr_Click(object sender, EventArgs e)
        {
            var id = this.Id;
            var newaddrUI = new fruNewPatientAddress(id, _email);

            newaddrUI.ShowDialog();
        }

        private void btnaddnewnote_Click(object sender, EventArgs e)
        {
            var editnote_ui = new fruEditPatientNote(Id, 0, _email, true);
            editnote_ui.ShowDialog();
        }

        private void gridnotes_DoubleClick(object sender, EventArgs e)
        {
        }

        private void cardView2_DoubleClick(object sender, EventArgs e)
        {
            var cv = (CardView)sender;
            dynamic ds = cv.DataSource;
            var selectedView = cv.OptionsSelection;
            //CardView view = (CardView)sender;
            //Point pt = view.GridControl.PointToClient(MousePosition);
            //GridHitInfo info = view..CalcHitInfo(pt);
            //if ((info.InRow || info.InRowCell) & info.Column != null)
            //{
            //    var grid = sender as CardView;
            //    Object cellValue = view.GetRowCellValue(info.RowHandle, info.Column);

            //    dynamic selected_row = grid.GetRow(info.RowHandle);
            //    if (selected_row != null)
            //    {
            //        new fruEditPatientNote(selected_row.Id, selected_row.PnId, "test@test.com").ShowDialog();
            //    }
            //}
        }

        private void cardView2_Click(object sender, EventArgs e)
        {
        }

        private async void btnnexttostep2_Click(object sender, EventArgs e)
        {
            var patient = GetPatient(this.Id);
            if (patient != null)
            {
                txtid.Text = patient.Id.ToString();
                txtssn.Text = patient.ssn_ou_identité;
                dtpublicationdate.Text = patient.Identité_date_de_publication;
                txtlicense.Text = patient.numero_carte_identité;
                dtexpirationdate.Text = patient.Identité_expiration;
                txtlicaddress.Text = patient.adresse_carte_identité;
                txtheight.Text = patient.taille;
                txteyes.Text = patient.yeux;
                txthair.Text = patient.cheveux;

                var edit = new Patients
                {
                    Id = patient.Id,
                    ssn_ou_identité = txtssn.Text,
                    Identité_date_de_publication = dtpublicationdate.Text,
                    numero_carte_identité = txtlicense.Text,
                    Identité_expiration = dtexpirationdate.Text,
                    adresse_carte_identité = txtlicaddress.Text,
                    taille = txtheight.Text,
                    yeux = txteyes.Text,
                    cheveux = txteyes.Text,


                    adresse = patient.adresse,
                    ajouter_au = patient.ajouter_au,
                    ajouter_par = patient.ajouter_par,
                    appartement = patient.appartement,
                    boite_postale = patient.boite_postale,
                    date_de_la_dernière_connexion = patient.date_de_la_dernière_connexion,
                    date_naissance = patient.date_naissance,
                    deuxième_nom = patient.deuxième_nom,
                    email = patient.email,
                    employeur = patient.employeur,
                    fax = patient.fax,
                    genre = patient.genre,
                    lieux_naissance = patient.lieux_naissance,
                    linkedin = patient.linkedin,
                    modifier_au = CommonHelpers.GetEuDate(),
                    modifier_par = CommonHelpers.GetSystemUserName(_email),
                    naissance = patient.naissance,
                    nom = patient.nom,
                    notes = patient.notes,
                    Pays = patient.Pays,
                    prénom = patient.prénom,
                    raison_de_la_visite = patient.raison_de_la_visite,
                    statut = patient.statut,
                    twitter = patient.twitter,
                    téléphone = patient.téléphone,
                    ville = patient.ville,
                    whatsapp = patient.whatsapp,
                    état_ou_région = patient.état_ou_région
                };
                var r1 = await _patRepos.SaveOrUpdateAsync(patient);
                if (r1 > 0)
                {
                    DevExpressFrHelper.DisplayMessage("Le patient a été mis à jour.");
                    xtraTabControl1.TabPages[0].PageEnabled = false;
                    xtraTabControl1.TabPages[1].PageEnabled = true;
                }
            }
        }

        private async void btnnextostep3_Click(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages[1].PageEnabled = false;
            xtraTabControl1.TabPages[2].PageEnabled = true;
        }

        private void btnvisitraisons_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtid.Text);
            new fruNewPatientRaisonVisite(_email, id).ShowDialog();
        }

        private void btnnexttostep4_Click(object sender, EventArgs e)
        {
        }


        private void btninfogenerals_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Guid.Parse(txtid.Text);
                var nom = txtlname.Text;
                var prénom = txtfname.Text;
                var deuxième_nom = txtmiddle.Text;
                var date_naissance = dtdob.Text;
                var lieux_naissance = txtlieunaiss.Text;
                var téléphone = txtphone.Text;
                var fax = txtfax.Text;
                var email = txtemail.Text;

                var genre = drpgenres.Text;
                //drpgenres.Update();

                var employeur = txtemployer.Text;
                var linkedin = txtlinkedin.Text;
                var whatsapp = txtwhatsapp.Text;
                var twitter = txtwitter.Text;

                var patient = new Patients
                {
                    Id = id,
                    nom = nom,
                    prénom = prénom,
                    deuxième_nom = deuxième_nom,
                    date_naissance = date_naissance,
                    lieux_naissance = lieux_naissance,
                    téléphone = téléphone,
                    fax = fax,
                    email = email,
                    genre = genre,
                    employeur = employeur,
                    linkedin = linkedin,
                    whatsapp = whatsapp,
                    twitter = twitter
                };
                var result = PatientHelpers.UpdateGeneralInformationAsync(patient);
                DevExpressFrHelper.DisplayMessage("Le patient a été mis à jour.");
                btninfogenerals.Enabled = false;
                xtraTabControl1.TabPages[2].PageEnabled = false;
                xtraTabControl1.TabPages[3].PageEnabled = true;
            }
            catch (Exception ex)
            {
                ex.LogToDb("private async void btnnexttostep5_Click", "fruEditPatient.cs", _email);
                throw ex;
            }
        }

        private async void btnnexttostep5_Click(object sender, EventArgs e)
        {
            if (txtaddr_notes.Text.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("L'adresse du patient a été mise à jour.");
            }
            else
            {
                try
                {
                    int result = 0;
                    var pat_addr = new Patient_Addresses
                    {
                        PadId = int.Parse(txtaddrId.Text),
                        Id = Guid.Parse(txtid.Text),
                        adresse = txtaddr.Text,
                        appartement = txtapartnumb.Text,
                        ville = txtcity.Text,
                        état_ou_région = txtregion.Text,
                        Pays = drpcountries.Text,
                        boite_postale = txtzip.Text,
                        téléphone = txttelephone2.Text,
                        Notes = txtaddr_notes.Text,
                        modifier_au = CommonHelpers.GetEuDate(),
                        modifier_par = CommonHelpers.GetSystemUserName(_email),
                        ajouter_au = txtaddr_ajouterau.Text,
                        ajouter_par = txtaddr_ajouterpar.Text
                    };

                    result = await _patAddressesRepos.SaveOrUpdateAsync(pat_addr);
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("L'adresse du patient a été mise à jour.");
                        btnnexttostep5.Enabled = false;
                        xtraTabControl1.TabPages[4].PageEnabled = false;
                        xtraTabControl1.TabPages[5].PageEnabled = true;
                    }

                }
                catch (Exception ex)
                {
                    ex.LogToDb("private async void btnnexttostep5_Click", "fruEditPatient.cs", _email);
                    throw ex;
                }
            }

        }

        private void btnscan_Click(object sender, EventArgs e)
        {

        }

        private void btnbrowseimage_Click(object sender, EventArgs e)
        {

        }
    }
}