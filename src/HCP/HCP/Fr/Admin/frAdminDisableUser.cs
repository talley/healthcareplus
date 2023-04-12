using DevExpress.XtraEditors;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HCP.Fr.Admin
{
    public partial class frAdminDisableUser : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _email;
        private IRepository<Users> _usersRepos = new UserRepository();

        public frAdminDisableUser(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private async void frAdminDisableUser_Load(object sender, EventArgs e)
        {
            var users= await _usersRepos.GetAllAsync();
            if(users != null)
            {
                var activeUsers=(from u in users
                                orderby u.email ascending
                                where u.Statut=="Actif"
                                select new
                                {
                                   u.Id, u.email,u.Nom,u.prénom,u.nom_role,
                                   u.ajouter_par
                                }).AsParallel().ToList();
                drpusers.Properties.DataSource= activeUsers;
                drpusers.Properties.DisplayMember = "Nom";
                drpusers.Properties.ValueMember = "Id";


                var inactiveUsers = (from u in users
                                   orderby u.email ascending
                                   where u.Statut == "InaActif"
                                   select new
                                   {
                                       u.Id,
                                       u.email,
                                       u.Nom,
                                       u.prénom,
                                       u.nom_role,
                                       u.ajouter_par
                                   }).AsParallel().ToList();
                drpusers2.Properties.DataSource = inactiveUsers;
                drpusers2.Properties.DisplayMember = "Nom";
                drpusers2.Properties.ValueMember = "Id";
            }
            else {
                this.Enabled = false;
            }
        }

        private void btndisable_Click(object sender, EventArgs e)
        {
            var sel = drpusers.Text;
            if (sel.Length == 0)
            {
                DevExpressFrHelper.ChooseValue();
            }
            else
            {
                var idtext = Guid.Parse(drpusers.EditValue.ToString());
                var user=new Users { Id= idtext };

                try
                {
                    var result = _usersRepos.Disable(user);
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("L'utilisateur a été désactivé.");
                        btndisable.Enabled = false;
                    }
                }
                catch (Exception ex) when(ex?.Message.Length>0)
                {

                    throw ex;
                }
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            var sel = drpusers2.Text;
            if (sel.Length == 0)
            {
                DevExpressFrHelper.ChooseValue();
            }
            else
            {
                var idtext = Guid.Parse(drpusers2.EditValue.ToString());
                var user = new Users { Id = idtext };

                try
                {
                    var result = _usersRepos.Enable(user);
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("L'utilisateur a été activé.");
                        btnactivate.Enabled = false;
                    }
                }
                catch (Exception ex) when (ex?.Message.Length > 0)
                {

                    throw ex;
                }
            }
        }
    }
}