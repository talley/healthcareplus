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
    public partial class frAdminEditUser : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _email;
        private readonly Users _users;
        private IRepository<UserStatuses> _userstatusesRepos = new UserStatusesRepository();
        private IRepository<Roles> _rolesRepos = new RoleRepository();
        private IRepository<Users> _usersRepos = new UserRepository();
        public frAdminEditUser(string email,Users users)
        {
            InitializeComponent();
            _email = email;
            _users = users;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frAdminEditUser_Load(object sender, EventArgs e)
        {

            if (_users != null)
            {
                this.Text = "Modifier l`utilisateur: " + _users.Id.ToString();
                txtemail.Text = _users.email;
                txtfname.Text = _users.prénom;
                txtlname.Text = _users.Nom;
                txtmiddle.Text = _users.deuxième_nom;
                txtnotes.Text = _users.notes;

                drproles.SelectedText = _users.nom_role;
                drpstatuses.SelectedText = _users.Statut;

                lblrole.Text = _users.nom_role;
                lblstatus.Text = _users.Statut;
            }

            var roles = await _rolesRepos.GetAllAsync();
            var roles_list = roles.OrderBy(x => x.nom_role).Select(x => new { x.nom_role, x.description }).ToList();

            var userstatuses = await _userstatusesRepos.GetAllAsync();
            var userstatuses_list = userstatuses.OrderBy(x => x.Statut).Select(x => new { x.Statut, x.description }).ToList();

            drproles.Properties.DataSource = roles_list;
            drproles.Properties.DisplayMember = "nom_role";
            drproles.Properties.ValueMember = "nom_role";

            drpstatuses.Properties.DataSource = userstatuses_list;
            drpstatuses.Properties.DisplayMember = "Statut";
            drpstatuses.Properties.ValueMember = "Statut";
        }

        private void btnedituser_Click(object sender, EventArgs e)
        {
            var email = txtemail.Text.Trim();
            var password = txtpass.Text.Trim();
            var confpassword = txtpassconf.Text.Trim();
            var role = drproles.Text;
            var status = drpstatuses.Text;
            var notes = txtnotes.Text.Trim();
            var lastname = txtlname.Text.Trim();
            var firstname = txtfname.Text.Trim();
            var middlename = txtmiddle.Text.Trim();


            if (email.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage("Email");
            }
            if (!email.IsEmailValid())
            {
                DevExpressFrHelper.DisplayMessage("Veuillez entrer un email valide");
            }
            else if (lastname.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage("Nom");
            }
            else if (firstname.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage("Prénom");
            }
            else if (role.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage(" Role");

            }
            else if (status.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage(" Statut");

            }
            else if (notes.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage(" Notes");

            }
            else
            {
                try
                {
                    if(password.Length == 0 && confpassword.Length==0)
                    {
                        var currentPass = _users.password;
                        var user = new Users
                        {
                            Id = _users.Id,
                            ajouter_au =_users.ajouter_au,
                            ajouter_par = _users.ajouter_par,
                            email = email,
                            nom_role = role,
                            notes = notes,
                            Statut = status,
                            password = currentPass,
                            Nom = lastname,
                            prénom = firstname,
                            deuxième_nom = middlename,
                            modifier_au=CommonHelpers.GetEuDate(),
                            modifier_par=CommonHelpers.GetSystemUserName(_email)
                        };

                        var result = _usersRepos.SaveOrUpdate(user);
                        if (result > 0)
                        {
                            DevExpressFrHelper.DisplayMessage("l'utilisateur a été mis  a jour");
                            btnedituser.Enabled = false;
                        }
                    }
                    else
                    {
                        byte[] enc_password = UserCustom.GetHashPassword(password);
                        var user = new Users
                        {
                            Id = _users.Id,
                            ajouter_au = _users.ajouter_au,
                            ajouter_par = _users.ajouter_par,
                            email = email,
                            nom_role = role,
                            notes = notes,
                            Statut = status,
                            password = enc_password,
                            Nom = lastname,
                            prénom = firstname,
                            deuxième_nom = middlename,
                            modifier_au = CommonHelpers.GetEuDate(),
                            modifier_par = CommonHelpers.GetSystemUserName(_email)
                        };

                        var result = _usersRepos.SaveOrUpdate(user);
                        if (result > 0)
                        {
                            DevExpressFrHelper.DisplayMessage("l'utilisateur a été mis  a jour");
                            btnedituser.Enabled = false;
                        }
                    }

                }
                catch (Exception ex) when (ex != null)
                {

                    DevExpressFrHelper.DisplayMessage(ex?.Message);
                }

            }
        }
    }
}