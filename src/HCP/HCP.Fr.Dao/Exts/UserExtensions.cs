using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Exts
{
    public static class UserExtensions
    {
        public static bool IsValidForUpdate(this Users user)
        {
            return user.email.Length > 0 && user.password.Length > 0 &&
                user.nom_role.Length > 0 && user.Statut.Length > 0 &&
                user.notes.Length > 0 && user.ajouter_au.Length > 0 &&
                user.ajouter_par.Length > 0;
        }

        public static bool IsValidForInsert(this Users user)
        {
            return user.email.Length > 0 && user.password != null &&
               user.nom_role.Length > 0 && user.Statut.Length > 0 &&
               user.notes.Length > 0 && user.ajouter_au.Length > 0 &&
               user.ajouter_par.Length > 0 && user.modifier_au.Length == 0 &&
               user.modifier_par.Length == 0 & user.Id == Guid.Empty;
        }
    }
}
