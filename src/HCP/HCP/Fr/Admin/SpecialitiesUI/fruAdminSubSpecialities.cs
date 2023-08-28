using DevExpress.XtraEditors;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using System;
using System.Data;
using System.Linq;

namespace HCP.Fr.Admin.SpecialitiesUI
{
    public partial class fruAdminSubSpecialities : XtraForm
    {
        string _email;
        private IRepository<Sub_Specialties> repos = new SubSpecialitiesRepository();

        public fruAdminSubSpecialities(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private async void fruAdminSubSpecialities_Load(object sender, EventArgs e)
        {
            var data = await repos.GetAllAsync();
            var data_needed = (from d in data
                               orderby d.Sous_Spécialité ascending
                               select new
                               {
                                   d.Id,
                                   d.Spécialité,
                                   d.Sous_Spécialité,
                                   d.Description,
                                   d.AjouterAu,
                                   d.AjouterPar,
                                   d.ModifierAu,
                                   d.ModifierPar
                               }).ToList();

            gridControl1.DataSource = data_needed;
        }
    }
}