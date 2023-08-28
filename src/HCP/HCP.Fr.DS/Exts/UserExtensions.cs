using System;

namespace HCP.Fr.DS.Exts
{
    public static class UserExtensions
    {
        public static bool IsValidForUpdate(this Users user)
        {
            var result = false;
            result= user.Id !=null && user.email.Length > 0 && user.password.Length > 0 &&
                user.nom_role.Length > 0 && user.Statut.Length > 0 &&
                user.notes.Length > 0 && user.modifier_au.Length > 0 &&
                user.modifier_par.Length > 0;
            return result;
        }

        public static bool IsValidForInsert(this Users user)
        {
            var result = false;
            result= user.email.Length > 0 && user.password.Length>0 &&
               user.nom_role.Length > 0 && user.Statut.Length > 0 &&
               user.notes.Length > 0 && user.ajouter_au.Length > 0 &&
               user.ajouter_par.Length > 0  && user.Id ==Guid.Empty;
            return result;
        }
    }
}
