using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using HCP.Fr.Dao.Exts;

namespace HCP.Fr.Dao.Repository
{
    public class UserRepository : IRepository<Users>
    {
        private HcpFrEntities db=new HcpFrEntities();
        public int Delete(Users entity)
        {
            var x = db.Users.SqlQuery($"DELETE FROM Users WHERE Id='{entity.Id}'");
            return x.Count();
        }

        public async Task<int> DeleteAsync(Users entity)
        {
            int result;
            var query = $"DELETE FROM Users WHERE Id='{entity.Id}'";
            using(IDbConnection sqlcon=new SqlConnection(db.Database.Connection.ConnectionString))
            {
                result= await sqlcon.ExecuteAsync(query).ConfigureAwait(false);

            }
            return result;
        }

        public int Disable(Users entity)
        {
            var result = 0;
            var query = $"UPDATE Users Set Statut='InaActif' WHERE Id='{entity.Id}'";

            try
            {
                using(IDbConnection sqlcon=new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    var tresult=sqlcon.Execute(query);
                    result = (int)tresult;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public async Task<int> DisableAsync(Users entity)
        {
            var result = 0;
            var query = $"UPDATE Users Set Statut='InaActif' WHERE Id='{entity.Id}'";

            try
            {
                using (IDbConnection sqlcon = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    var tresult =await sqlcon.ExecuteAsync(query).ConfigureAwait(false);
                    result = (int)tresult;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }


        /// <summary>
        /// Ensures the model is valid.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>

        public int Enable(Users entity)
        {
            var result = 0;
            var query = $"UPDATE Users Set Statut='Actif' WHERE Id='{entity.Id}'";

            try
            {
                using (IDbConnection sqlcon = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    var tresult = sqlcon.Execute(query);
                    result = (int)tresult;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public async Task<int> EnableAsync(Users entity)
        {
            var result = 0;
            var query = $"UPDATE Users Set Statut='Actif' WHERE Id='{entity.Id}'";

            try
            {
                using (IDbConnection sqlcon = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    var tresult = await sqlcon.ExecuteAsync(query).ConfigureAwait(false);
                    result = (int)tresult;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
        public bool EnsureModelIsValid(Users entity)
        {
            return entity.IsValidForUpdate();
        }

        public bool EnsureModelIsValidForInsert(Users entity)
        {
            return entity.IsValidForInsert();
        }

        public bool EnsureModelIsValidForUpdate(Users entity)
        {
            return entity.IsValidForUpdate();
        }

        public List<Users> GetAll()=>db.Users.AsList();

        public async Task<List<Users>> GetAllAsync()=> await db.Users.ToListAsync().ConfigureAwait(false);


        public Users GetById(Users entity) => db.Users.SingleOrDefault(x => x.Id == entity.Id);

        public async Task<Users> GetByIdAsync(Users entity)=> await db.Users.SingleOrDefaultAsync(x => x.Id == entity.Id).ConfigureAwait(false);


        public int Save()=>db.SaveChanges();


        public async Task<int> SaveAsync()=>await db.SaveChangesAsync().ConfigureAwait(false);


        public int SaveOrUpdate(Users entity)
        {
            int result = 0;
            try
            {
                if (entity.Id == Guid.Empty)
                {
                    entity.Id = Guid.NewGuid();
                    db.Entry(entity).State = EntityState.Added;
                    db.Users.Add(entity);
                    result = Save();

                }
                else
                {
                    var edit = GetById(entity);
                    edit.email = entity.email;
                    edit.password=entity.password;
                    edit.ajouter_par=entity.ajouter_par;
                    edit.ajouter_au=entity.ajouter_au;
                    edit.notes=entity.notes;
                    edit.date_de_la_dernière_connexion = entity.date_de_la_dernière_connexion;
                    edit.nom_role=entity.nom_role;
                    edit.modifier_au=entity.modifier_au;
                    edit.modifier_par=entity.modifier_par;
                    edit.Nom=entity.Nom;
                    edit.prénom = entity.prénom;
                    edit.deuxième_nom = entity.deuxième_nom;

                    db.Entry(edit).State = EntityState.Modified;
                    result = Save();
                }
            }
            catch (Exception ex) when(ex!=null)
            {

                throw ex;
            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(Users entity)
        {
            int result = 0;
            try
            {
                if (entity.Id == Guid.Empty)
                {
                    db.Entry(entity).State = EntityState.Added;
                    db.Users.Add(entity);
                    result = Save();

                }
                else
                {
                    var edit =await GetByIdAsync(entity);
                    edit.email = entity.email;
                    edit.password = entity.password;
                    edit.ajouter_par = entity.ajouter_par;
                    edit.ajouter_au = entity.ajouter_au;
                    edit.notes = entity.notes;
                    edit.date_de_la_dernière_connexion = entity.date_de_la_dernière_connexion;
                    edit.nom_role = entity.nom_role;
                    edit.modifier_au = entity.modifier_au;
                    edit.modifier_par = entity.modifier_par;
                    edit.Nom = entity.Nom;
                    edit.prénom = entity.prénom;
                    edit.deuxième_nom = entity.deuxième_nom;

                    db.Entry(edit).State = EntityState.Modified;
                    result = Save();
                }
            }
            catch (Exception ex) when (ex != null)
            {

                throw ex;
            }
            return result;
        }
    }
}
