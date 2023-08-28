// Ignore Spelling: bmp btnuploadimage finfo

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Fr.Helpers;
using HCP.Helpers;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WIA;

namespace HCP.Fr.User
{
    public partial class fruNewPatient : XtraForm
    {
        readonly string _email;
        // private ReadOnyDataRepository
        private IRepository<Patients> _patRepos = new PatientRepository();
        private IRepository<PatientsNotes> _patNote_Repos = new PatientNoteRepository();
        private IRepository<PatientsVisitNotes> _patVisitNoteRepos = new PatientVisitNoteRepository();
        private IRepository<Patient_Addresses> _patAddressesRepos = new PatientAddressRepository();
        private IRepository<SecuritySsn> ssnrepo = new PatientSsnRepository();
        public fruNewPatient(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private async void fruNewPatient_Load(object sender, EventArgs e)
        {
            this.Text = "Ajouter un Patient";
            //xtraTabControl1.TabPages[1].PageEnabled = false;
            //xtraTabControl1.TabPages[2].PageEnabled = false;
            //xtraTabControl1.TabPages[3].PageEnabled = false;
            //xtraTabControl1.TabPages[4].PageEnabled = false;
            //xtraTabControl1.TabPages[5].PageEnabled = false;
            //xtraTabControl1.TabPages[6].PageEnabled = false;

            var scanners = GetScanners();
            drpscanners.Properties.DataSource = scanners;

            var genders = ReadOnlyDataRepository.GetGenders();
            drpgenres.Properties.DataSource = genders;
            BestFitLookupEdit(drpgenres);

            var countries = await ReadOnlyDataRepository.GetCountriesAsync();
            drpcountries.Properties.DataSource = countries.Select(x => new { x.Nom, x.Code2, x.Code3 }).ToList();
            drpcountries.Properties.DisplayMember = "Nom";
            drpcountries.Properties.ValueMember = "Nom";
            BestFitLookupEdit(drpcountries);

            var imageTypes = await ReadOnlyDataRepository.GetIdentityTypesAsync();
            drpimagetypes.Properties.DataSource = imageTypes.Select(x => new { x.Type, x.description }).ToList();
            drpimagetypes.Properties.DisplayMember = "Type";
            drpimagetypes.Properties.ValueMember = "Type";
            BestFitLookupEdit(drpimagetypes);



        }

        private List<string> GetScanners()
        {
            // MC.enableWIA();
            var scanners = new List<string>();
            string deviceName = "";

            DeviceManager deviceManager = new DeviceManager();
            // Loop through the list of devices and add the name to the listbox

            foreach (DeviceInfo info in deviceManager.DeviceInfos)
            {
                if (info.Type == WIA.WiaDeviceType.ScannerDeviceType)
                {
                    foreach (Property p in info.Properties)
                    {
                        if (p.Name == "Name")
                        {
                            deviceName = ((IProperty)p).get_Value().ToString();
                            scanners.Add(deviceName);
                        }
                    }
                }

            }
            return scanners;
        }

        private void BestFitLookupEdit(LookUpEdit lookupctrl)
        {
            lookupctrl.Properties.BestFit();
            int width = 0;
            foreach (LookUpColumnInfo column in lookupctrl.Properties.Columns)
                width += column.Width;
            lookupctrl.Properties.PopupWidth = width + 4;
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ultraLabel15_Click(object sender, EventArgs e)
        {

        }

        private void textEdit11_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ultraLabel16_Click(object sender, EventArgs e)
        {

        }

        private void textEdit12_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit8_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ultraLabel10_Click(object sender, EventArgs e)
        {

        }

        private void ultraLabel9_Click(object sender, EventArgs e)
        {

        }

        private void btngenssn_Click(object sender, EventArgs e)
        {
            var ssn = txtssn.Text;
            var ssns = CommonHelpers.GetAvailabeSsns();
            //if (ssn.Length == 0)
            //{
            //    DevExpressFrHelper.DisplayErrorMessage(" Numéro de sécurité sociale ou Générer le numéro de sécurité sociale");
            //}
            //else
            //{
                if (ssns.Any() && ssns.SingleOrDefault(x => x == ssn) != null)
                {
                    DevExpressFrHelper.DisplayMessage("Ce numéro de sécurité sociale existe déjà.");
                }
                else
                {
                    var new_ssn = CommonHelpers.GenerateSsn();
                    txtssn.Text = new_ssn;
                }
           // }
        }

        private async void btnnexttostep2_Click(object sender, EventArgs e)
        {
            var ssn = txtssn.Text;
            var license = txtlicense.Text;
            var licaddress = txtlicense.Text;
            var eyes = txteyes.Text;
            var hair = txthair.Text;
            var expiration_date = dtexpirationdate.Text;
            var issuing_date = dtpublicationdate.Text;
            var height = txtheight.Text;

            if (ssn.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez entrer le numéro de sécurité sociale ou générer un");
            }
            else if (license.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage(" license ou N/A");
            }
            else if (licaddress.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage(" address sur la license ou entrer N/A");
            }
            else if (licaddress.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage(" address sur la license ou entrer N/A");
            }
            else if (eyes.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage(" dimensions des yeux");
            }
            else if (hair.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage(" dimensions des cheveux");
            }
            else if (height.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage(" dimensions de la taille");
            }
            else if (expiration_date.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage(" date d'expiration ou date d`aujourdhui");
            }
            else if (issuing_date.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage(" date d'émission ou date d`aujourdhui");
            }
            else
            {

                var patient1 = new Patients
                {
                    ssn_ou_identité = ssn,
                    numero_carte_identité = license,
                    adresse_carte_identité = licaddress,
                    Identité_expiration = expiration_date,
                    Identité_date_de_publication = issuing_date,
                    yeux = eyes,
                    cheveux = hair,
                    taille = height,
                    nom = "N/A",
                    prénom = "N/A",
                    deuxième_nom = "N/A",
                    date_naissance = "N/A",
                    raison_de_la_visite = "N/A",
                    adresse = "N/A",
                    appartement = "N/A",
                    ville = "N/A",
                    état_ou_région = "N/A",
                    Pays = "N/A",
                    boite_postale = "N/A",
                    genre = "N/A",
                    naissance = "N/A",
                    lieux_naissance = "N/A",
                    téléphone = "N/A",
                    fax = "N/A",
                    email = "N/A",
                    twitter = "N/A",
                    whatsapp = "N/A",
                    linkedin = "N/A",
                    employeur = "N/A",
                    notes = "N/A",
                    statut = "N/A",
                    ajouter_au = CommonHelpers.GetEuDate(),
                    ajouter_par = CommonHelpers.GetSystemUserName(_email)


                };
                int result = await _patRepos.SaveOrUpdateAsync(patient1);
                if (result > 0)
                {
                    var ssnData = new SecuritySsn
                    {
                        Ssn=txtssn.Text,
                        ajouter_au=CommonHelpers.GetEuDate(),
                        ajouter_par=CommonHelpers.GetSystemUserName(_email),
                        utilisateur_id=Guid.NewGuid(),//==FIX ME==
                    };
                    var result2 =await ssnrepo.SaveOrUpdateAsync(ssnData);
                    DevExpressFrHelper.DisplayMessage("Le patient a été ajouté.Veuillez ajouter des notes du patient.");
                    btnnexttostep2.Enabled = false;
                    var edit1 = _patRepos.GetAll().SingleOrDefault(x => x.ssn_ou_identité == ssn);
                    txtid.Text = edit1.Id.ToString();
                }
            }
        }

        private async void btnnextostep3_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(txtid.Text);

            var notes = txtraisonvisite.Text;
            if (notes.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez ajouter des notes DU patient.");
            }
            else
            {
                var patNote = new PatientsVisitNotes
                {
                    Id = id,
                    Notes = notes,
                    ajouter_au = CommonHelpers.GetEuDate(),
                    ajouter_par = CommonHelpers.GetSystemUserName(_email)
                };
                var result2 = await _patVisitNoteRepos.SaveOrUpdateAsync(patNote);
                if (result2 > 0)
                {
                    DevExpressFrHelper.DisplayMessage("La note du patient a été ajoutée.Veuillez ajouter des informations générales.");
                    btnnextostep3.Enabled = false;
                }
            }
        }

        private async void btnnexttostep4_Click(object sender, EventArgs e)
        {
            try
            {
                var id =  Guid.Parse(txtid.Text);
                var patients = _patRepos.GetAll();
                if (patients.Any())
                {

                    var find = patients.SingleOrDefault(x => x.Id == id);

                    var lname = txtlname.Text;
                    var fname = txtfname.Text;
                    var middleName = txtmiddle.Text;
                    var dob = dtdob.Text;
                    var birthPlace = txtlieunaiss.Text;
                    var gender = drpgenres.Text;
                    var phone = txtphone.Text;
                    var fax = txtfax.Text;
                    var email = txtemail.Text;
                    var whatsapp = txtwhatsapp.Text;
                    var twitter = txtwitter.Text;
                    var linkedin = txtlinkedin.Text;
                    var employer = txtemployer.Text;
                    if (lname.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" nom");
                    }
                    else if (fname.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" prénom");
                    }
                    else if (dob.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" date de naissance");
                    }
                    else if (birthPlace.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" téléphone");
                    }
                    else if (gender.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" genre");
                    }
                    else if (phone.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" genre");
                    }
                    else if (email.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" email");
                    }
                    else if (!EmailHelper.IsValidEmail(email))
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" email valide");
                    }
                    else if (employer.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" employeur");
                    }
                    else
                    {
                        var pat = new Patients
                        {
                            Id = id,
                            ssn_ou_identité = find.ssn_ou_identité,
                            numero_carte_identité = find.numero_carte_identité,
                            adresse_carte_identité = find.adresse_carte_identité,
                            yeux = find.yeux,
                            cheveux = find.cheveux,
                            Identité_date_de_publication = find.Identité_date_de_publication,
                            Identité_expiration = find.Identité_expiration,
                            taille = find.taille,
                            nom = lname,
                            prénom = fname,
                            deuxième_nom = middleName,
                            date_naissance = dob,
                            lieux_naissance = birthPlace,
                            genre = gender,
                            téléphone = phone,
                            fax = fax,
                            email = email,
                            whatsapp = whatsapp,
                            twitter = twitter,
                            linkedin = linkedin,
                            employeur = employer,
                            adresse = "N/A",
                            ajouter_au = find.ajouter_au,
                            ajouter_par = find.ajouter_par,
                            appartement = "N/A",
                            boite_postale = "N/A",
                            date_de_la_dernière_connexion = "N/A",
                            naissance = "N/A", //to be removed
                            notes = "N/A",//to be removed
                            Pays = "N/A",
                            raison_de_la_visite = "N/A", //to be removed
                            statut = "Actif",
                            ville = "N/A",
                            modifier_au = CommonHelpers.GetEuDate(),
                            modifier_par = CommonHelpers.GetSystemUserName(_email),
                            état_ou_région = "N/A"
                            //SecuritySsn = find.SecuritySsn
                        };

                        var result = await _patRepos.SaveOrUpdateAsync(pat);
                        if (result > 0)
                        {
                            DevExpressFrHelper.DisplayMessage("Le patient a été mis à jour.Veuillez ajouter une note.");
                            btnnexttostep4.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex) when (ex != null)
            {

                throw ex;
            }

        }

        private async void simpleButton4_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(txtid.Text);
            var patients = _patRepos.GetAll();
            try
            {
                var find = patients.SingleOrDefault(x => x.Id == id);
                var patientNote = new PatientsNotes
                {
                    ajouter_au = CommonHelpers.GetEuDate(),
                    ajouter_par = CommonHelpers.GetSystemUserName(_email),
                    Notes = txtnotes.Text,
                    Id = id,
                };
                var result = await _patNote_Repos.SaveOrUpdateAsync(patientNote);
                if (result > 0)
                {
                    DevExpressFrHelper.DisplayMessage("La note du patient a été ajoutée.Veuillez ajouter l`adresse");
                    simpleButton4.Enabled = false;
                }
            }
            catch (Exception ex) when (ex != null)
            {
                throw ex;
            }
        }

        private async void btnnexttostep5_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Guid.Parse(txtid.Text);
                var patients = _patRepos.GetAll();
                if (patients.Any())
                {

                    var find = patients.SingleOrDefault(x => x.Id == id);
                    var ssn = find.ssn_ou_identité;
                    var idcard = find.numero_carte_identité;
                    var idaddress = find.adresse_carte_identité;
                    var eyes = find.yeux;
                    var hair = find.cheveux;
                    var expiration_date = find.Identité_expiration ?? dtexpirationdate.Text;
                    var issuing_date = find.Identité_date_de_publication ?? dtpublicationdate.Text;
                    var height = find.taille ?? txtheight.Text;

                    var lname = find.nom;
                    var fname = find.prénom;
                    var middleName = find.deuxième_nom;
                    var dob = find.date_naissance;
                    var birthPlace = find.lieux_naissance;
                    var gender = find.genre;
                    var phone = find.téléphone;
                    var fax = find.fax;
                    var email = find.email;
                    var whatsapp = find.whatsapp;
                    var twitter = find.twitter;
                    var linkedin = find.linkedin;
                    var employer = find.employeur;

                    var address = txtaddr.Text;
                    var apartment = txtapartnumb.Text;
                    var ville = txtcity.Text;
                    var region = txtregion.Text;
                    var zip = txtzip.Text;
                    var country = drpcountries.Text;
                    var phone2 = txttelephone2.Text;


                    if (address.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" adresse");
                    }
                    else if (apartment.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" appartement");
                    }
                    else if (ville.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" ville");
                    }
                    else if (region.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" région");
                    }
                    else if (zip.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" boite postale");
                    }
                    else if (country.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" pays");
                    }
                    else if (phone2.Length == 0)
                    {
                        DevExpressFrHelper.DisplayErrorMessage(" téléphone");
                    }
                    else
                    {
                        var pataddr = new Patient_Addresses
                        {
                            adresse = address,
                            ajouter_au = CommonHelpers.GetEuDate(),
                            ajouter_par = CommonHelpers.GetSystemUserName(_email),
                            appartement = apartment,
                            boite_postale = zip,
                            Pays = country,
                            ville = ville,
                            état_ou_région = region,
                            téléphone = phone2,
                            PadId = 0,
                            Id=id
                        };

                        var result = await _patAddressesRepos.SaveOrUpdateAsync(pataddr);
                        if (result > 0)
                        {
                            DevExpressFrHelper.DisplayMessage("L'adresse du patient a été ajoutée.Veuillez télécharger une photo ou une identité.");
                            btnnexttostep5.Enabled = false;


                        }
                    }
                }
            }
            catch (Exception ex) when (ex != null)
            {

                throw ex;
            }
        }

        private void btnbrowseimage_Click(object sender, EventArgs e)
        {
            var initDir = @"C:\scans\images";
            if (!Directory.Exists(initDir))
            {
                Directory.CreateDirectory(initDir);
            }
            xtraOpenFileDialog1.InitialDirectory = initDir;
            xtraOpenFileDialog1.Filter = "Fichiers images (*.png)|*.png|Fichiers images (*.jpg)|*.jpg";

            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file.
                string filePath = xtraOpenFileDialog1.FileName;
                txtimage.Text = filePath;

                // Read the contents of the file into a stream.
                var fileStream = xtraOpenFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    imagePicEdit.Image = Image.FromFile(filePath);
                }
            }



            //ValidatorFactory valFactory = EnterpriseLibraryContainer.Current.GetInstance<ValidatorFactory>();

            //Validator<AttributeGeneralInfo> ginfoValidator =valFactory.CreateValidator<AttributeGeneralInfo>();

            //var generalInfo = new AttributeGeneralInfo
            //{
            //    Email = email,
            //    Employeur = employer,
            //    Fax = fax,
            //    Genre = gender,
            //    Phone = phone,
            //    LieuxNaissance = birthPlace,
            //    LinkedIn = linkedin,
            //    Naissance = dob,
            //    Nom = lname,
            //    Prenom = fname,
            //    Twitter = twitter,
            //    Whatsapp = whatsapp
            //};

            //var ginfoResult=ginfoValidator.Validate(generalInfo);

            //if (ginfoResult.IsValid)
            //{
            //    MessageBox.Show("Customer information is valid");
            //}
            //else
            //{
            //    foreach (ValidationResult info in ginfoResult)
            //    {
            //        // Put your validation detection logic
            //        DevExpressFrHelper.DisplayMessage(info.Key);
            //        foreach(var y in info.NestedValidationResults)
            //        {
            //            DevExpressFrHelper.DisplayMessage(y.Message);
            //        }
            //    }
            //}
        }

        private void btnscan_Click(object sender, EventArgs e)
        {
            ICommonDialog dialog = new WIA.CommonDialog();
            Device device = dialog.ShowSelectDevice(WIA.WiaDeviceType.UnspecifiedDeviceType, true, false);
            var WiaDeviceId = new DeviceInfo();// device.DeviceID;
            var WiaDeviceName = device.DeviceID;
            DeviceManager deviceManager = new DeviceManager();

            if (!string.IsNullOrEmpty(WiaDeviceName))
            {
                IEnumerable<DeviceInfo> devices =
                deviceManager.DeviceInfos.OfType<DeviceInfo>()
                .Where(x => x.DeviceID == (string)WiaDeviceName);
                if (devices != null && devices.Count() > 0)
                {
                    WiaDeviceId = devices.FirstOrDefault();
                }
            }
            WiaDeviceId.Connect(); //Connects to selected Scanner
            if (ckduplex.Checked)
            {
                device.Properties.get_Item("3088").set_Value(5); // Double scanning or dublex scanning
            }
            else
            {
                device.Properties.get_Item("3088").set_Value(1);// Single scanning or simplex scanning
            }

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnuploadimage_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                var filePath = txtimage.Text;
                string fileType = "";
                Guid PatientId = Guid.Parse(txtid.Text);
                if (string.IsNullOrEmpty(filePath))
                {
                    DevExpressFrHelper.DisplayMessage("Veuillez choisir un fichier");
                }
                else
                {
                    var finfo = new FileInfo(filePath);
                    var Size = finfo.Length;
                    var addedOn = CommonHelpers.GetEuDate();
                    var addedBy = CommonHelpers.GetSystemUserName(_email);
                    switch (filePath.GetExtension())
                    {
                        case ".png":
                            var bmp1 = new Bitmap(filePath);
                            result = await PatientHelpers.AddPatientIdentityAsync(PatientId, fileType, filePath, Size.ToString(), bmp1.Height.ToString(),
                                bmp1.Width.ToString(), addedOn, addedBy);
                            break;
                        case ".jpg":
                            var bmp2 = new Bitmap(filePath);
                            result = await PatientHelpers.AddPatientIdentityAsync(PatientId, fileType, filePath, Size.ToString(), bmp2.Height.ToString(),
                               bmp2.Width.ToString(), addedOn, addedBy);
                            break;
                        case ".tiff":
                            var bmp3 = new Bitmap(filePath);
                            result = await PatientHelpers.AddPatientIdentityAsync(PatientId, fileType, filePath, Size.ToString(), bmp3.Height.ToString(),
                               bmp3.Width.ToString(), addedOn, addedBy);
                            break;
                        case ".bmp":
                            var bmp4 = new Bitmap(filePath);
                            result = await PatientHelpers.AddPatientIdentityAsync(PatientId, fileType, filePath, Size.ToString(), bmp4.Height.ToString(),
                               bmp4.Width.ToString(), addedOn, addedBy);
                            break;
                        default:
                            result = await PatientHelpers.AddPatientIdentityAsync(PatientId, fileType, filePath, Size.ToString(), "N/A",
                            "N/A", addedOn, addedBy);
                            break;
                    }
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("Un fichier ou une image a été ajouté.");
                    }

                } //end else
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    class AttributeGeneralInfo
    {
        [NotNullValidator(MessageTemplate = "Veuillez entrer le nom")]
        //[StringLengthValidator(5, RangeBoundaryType.Inclusive,5, RangeBoundaryType.Inclusive,MessageTemplate = "Customer no must have {3} characters.")]
        //[RegexValidator("[A-Z]{2}[0-9]{3}",MessageTemplate = "Customer no must be 2 capital letters and 3 numbers.")]
        public string Nom { get; set; }
        [NotNullValidator(MessageTemplate = "Veuillez entrer le prénom")]
        public string Prenom { get; set; }

        [NotNullValidator(MessageTemplate = "s'il vous plaît entrer la naissance")]
        public string Naissance { get; set; }
        [NotNullValidator(MessageTemplate = "s'il vous plaît entrer lieux de naissance")]
        public string LieuxNaissance { get; set; }
        [NotNullValidator(MessageTemplate = "s'il vous plaît choisir le genre")]
        public string Genre { get; set; }
        [NotNullValidator(MessageTemplate = "s'il vous plaît entrer un numéro de téléphone valide")]
        public string Phone { get; set; }
        public string Fax { get; set; }
        [NotNullValidator(MessageTemplate = "Veuillez saisir un e-mail")]
        [RegexValidator(@"^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", MessageTemplate = "Veuillez entrer un email valide.")]
        public string Email { get; set; }
        public string Whatsapp { get; set; }

        public string Twitter { get; set; }

        public string LinkedIn { get; set; }
        [NotNullValidator(MessageTemplate = "Veuillez entrer l'employeur")]
        public string Employeur { get; set; }

    }
}
