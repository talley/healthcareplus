using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class PatientSsnRepository : IRepository<SecuritySsn>
    {
        internal HcpFrEntities db = new HcpFrEntities();

        public int Delete(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(SecuritySsn entity)
        {
            throw new NotImplementedException();
        }

        public List<SecuritySsn> GetAll()=>db.SecuritySsn.ToList();


        public async Task<List<SecuritySsn>> GetAllAsync()=> await db.SecuritySsn.ToListAsync()
            .ConfigureAwait(false);


        public SecuritySsn GetById(SecuritySsn entity)
        {
           return db.SecuritySsn.SingleOrDefault(x=>x.Ssn==entity.Ssn);
        }

        public async Task<SecuritySsn> GetByIdAsync(SecuritySsn entity)
        {
            return await db.SecuritySsn.SingleOrDefaultAsync(x => x.Ssn == entity.Ssn)
                .ConfigureAwait(false);
        }

        public int Save()=>db.SaveChanges();


        public async Task<int> SaveAsync() => await db.SaveChangesAsync().ConfigureAwait(false);


        public int SaveOrUpdate(SecuritySsn entity)
        {
            int result = 0;
            if (entity.SsnId == 0)
            {
                db.Entry(entity).State = EntityState.Added;
                result = Save();
            }
            else
            {
                var edit = GetById(entity);
                if (edit == null)
                {
                    throw new Exception("Cet Ssn existe deja");
                }
                edit.Ssn = entity.Ssn;
                edit.utilisateur_id = entity.utilisateur_id;
                edit.ajouter_au=entity.ajouter_au;
                edit.ajouter_par=entity.ajouter_par;
                edit.modifier_au=entity.modifier_au;
                edit.modifier_par=entity.modifier_par;

                db.Entry(edit).State = EntityState.Modified;
                result = Save();

            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(SecuritySsn entity)
        {
            int result = 0;
            if (entity.SsnId == 0)
            {
              db.Entry(entity).State = EntityState.Added;
                result = await SaveAsync();
            }
            else
            {
                var edit = GetById(entity);
                if (edit == null)
                {
                    throw new Exception("Cet Ssn existe deja");
                }
                edit.Ssn = entity.Ssn;
                edit.utilisateur_id = entity.utilisateur_id;
                edit.ajouter_au = entity.ajouter_au;
                edit.ajouter_par = entity.ajouter_par;
                edit.modifier_au = entity.modifier_au;
                edit.modifier_par = entity.modifier_par;

                db.Entry(edit).State = EntityState.Modified;
                result = await SaveAsync();

            }
            return result;
        }
    }
}
