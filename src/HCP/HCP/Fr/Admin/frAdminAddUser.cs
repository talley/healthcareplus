using DevExpress.XtraEditors;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Helpers;
using System;
using System.Data;
using System.Linq;

namespace HCP.Fr.Admin
{
    public partial class frAdminAddUser : XtraForm
    {
        private IRepository<UserStatuses> _userstatusesRepos = new UserStatusesRepository();
        private IRepository<Roles> _rolesRepos = new RoleRepository();
        private IRepository<Users> _usersRepos = new UserRepository();
        private string _email;
        public frAdminAddUser(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private async void frAdminAddUser_Load(object sender, EventArgs e)
        {
            var roles = await _rolesRepos.GetAllAsync();
            var roles_list = roles.OrderBy(x => x.nom_role).Select(x => new { x.nom_role,x.description}).ToList();

            var userstatuses=await _userstatusesRepos.GetAllAsync();
            var userstatuses_list=userstatuses.OrderBy(x=>x.Statut).Select(x => new { x.Statut,x.description }).ToList();

            drproles.Properties.DataSource = roles_list;
            drproles.Properties.DisplayMember = "nom_role";
            drproles.Properties.ValueMember = "nom_role";

            drpstatuses.Properties.DataSource = userstatuses_list;
            drpstatuses.Properties.DisplayMember = "Statut";
            drpstatuses.Properties.ValueMember = "Statut";


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            var email=txtemail.Text.Trim();
            var password=txtpass.Text.Trim();
            var confpassword=txtpassconf.Text.Trim();
            var role=drproles.Text;
            var status = drpstatuses.Text;
            var notes=txtnotes.Text.Trim();
            var lastname=txtlname.Text.Trim();
            var firstname=txtfname.Text.Trim();
            var middlename=txtmiddle.Text.Trim();


            if (email.Length == 0)
            {
                DevExpressFrHelper.DisplayErrorMessage("Email");
            }
            if (!email.IsEmailValid())
            {
                DevExpressFrHelper.DisplayMessage("Veuillez entrer un email valide");
            }
            else if(password.Length == 0) {

                DevExpressFrHelper.DisplayErrorMessage(" Mot de passe");

            }
            else if (confpassword.Length == 0)
            {

                DevExpressFrHelper.DisplayErrorMessage(" Mot de passe");

            }
            else if(confpassword !=password)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez confirmer le mot de passe");
            }
            else if(lastname.Length == 0)
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
                    byte[] enc_password = UserCustom.GetHashPassword(password);
                    var user = new Users
                    {
                        Id = Guid.Empty,
                        ajouter_au = CommonHelpers.GetEuDate(),
                        ajouter_par = CommonHelpers.GetSystemUserName(_email),
                        email = email,
                        nom_role = role,
                        notes = notes,
                        Statut = status,
                        password = enc_password,
                        Nom=lastname,
                        prénom=firstname,
                        deuxième_nom=middlename
                    };

                    var result = _usersRepos.SaveOrUpdate(user);
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("l'utilisateur a été ajouté");
                        btnadduser.Enabled = false;
                    }
                }
                catch (Exception ex)when(ex!=null)
                {

                    DevExpressFrHelper.DisplayMessage(ex?.Message);
                }

            }

        }
    }
}