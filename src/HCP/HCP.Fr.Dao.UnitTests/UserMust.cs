using System;
using System.Collections.Generic;
using Xunit;
using HCP.Fr.DS;
using HCP.Fr.DS.Exts;
namespace HCP.Fr.Dao.UnitTests
{
    public class UserMust
    {

        [Fact]
        public void NotBeValidForInsert()
        {
            var user = new Users { ajouter_au = DateTime.Now.ToString(),email="t@t.com",
                Id=Guid.NewGuid(),nom_role="User",Statut="",
                modifier_au=null,modifier_par=null,ajouter_par=Environment.MachineName,
                date_de_la_dernière_connexion = null,notes=null,password=null
            };
            var expected=user.IsValidForInsert();
            var actual = false;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BeValidForInsert()
        {
            var user = new Users
            {
                ajouter_au = DateTime.Now.ToString(),
                email = "t@t.com",
                Id = Guid.Empty,
                nom_role = "User",
                Statut = "Actif",
                ajouter_par = Environment.MachineName,
                notes = "mmmmm",
                password=System.Text.Encoding.UTF8.GetBytes("hello")

            };
            var expected = user.IsValidForInsert();
            var actual = true;

            Assert.Equal(expected, actual);
        }
    }
}
