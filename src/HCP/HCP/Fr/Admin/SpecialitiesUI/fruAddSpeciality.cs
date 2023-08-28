using DevExpress.XtraEditors;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Fr.Logging;
using HCP.Helpers;
using System;
using System.Data;
using System.Linq;

namespace HCP.Fr.Admin.SpecialitiesUI
{
    public partial class fruAddSpeciality : XtraForm
    {
        string _email;

        private IRepository<Specialities> repos = new SpecialityRepository();

        public fruAddSpeciality(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private async void fruAddSpeciality_Load(object sender, EventArgs e)
        {
            this.Text = "Spécialités";
            var sps = await repos.GetAllAsync();
            var needed_sps = (from s in sps
                              orderby s.Spécialité ascending
                              select new
                              {
                                  s.Id,
                                  s.Spécialité,
                                  s.Statut,
                                  s.AjouterAu,
                                  s.AjouterPar,
                                  s.ModifierAu,
                                  s.ModifierPar
                              }).ToList();

            gridControl1.DataSource = needed_sps;
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                var speciality = txtspeciality.Text;
                var status = ckstatus.Checked;
                var desc = txtdesc.Text;

                if (speciality.Length == 0)
                {
                    DevExpressFrHelper.DisplayErrorMessage("Spécialité");
                }
                else if (desc.Length == 0)
                {
                    DevExpressFrHelper.DisplayErrorMessage("Description");
                }
                else
                {
                    var sp = new Specialities
                    {
                        Id = 0,
                        AjouterAu = CommonHelpers.GetEuDate(),
                        AjouterPar = CommonHelpers.GetSystemUserName(_email),
                        Description = desc,
                        Spécialité = speciality,
                        Statut = status
                    };

                    var result = await repos.SaveOrUpdateAsync(sp);
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("La spécialité a été ajoutée.");
                        btnadd.Enabled = false;
                        fruAddSpeciality_Load(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.LogToDb("private async void btnadd_Click", "fruAddSpeciality.cs", _email);
                throw ex;
            }
        }
    }
}