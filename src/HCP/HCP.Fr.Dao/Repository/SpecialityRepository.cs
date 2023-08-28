using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class SpecialityRepository : IRepository<Specialities>
    {
        internal HcpFrEntities db = new HcpFrEntities();

        public int Delete(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(Specialities entity)
        {
            throw new NotImplementedException();
        }

        public List<Specialities> GetAll()
        {
            return db.Specialities.ToList();
        }

        public async Task<List<Specialities>> GetAllAsync()
        {
            return await db.Specialities.ToListAsync().ConfigureAwait(false);
        }

        public Specialities GetById(Specialities entity)
        {
            return db.Specialities.SingleOrDefault(x => x.Id == entity.Id);
        }

        public async Task<Specialities> GetByIdAsync(Specialities entity)
        {
            return await db.Specialities.SingleOrDefaultAsync(x => x.Id == entity.Id);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public int SaveOrUpdate(Specialities entity)
        {
            int result = 0;
            if (entity.Id == 0)
            {
                db.Entry(entity).State = EntityState.Added;
                db.Specialities.Add(entity);
                result = Save();
            }
            else
            {
                var edit = GetById(entity);
                edit.Spécialité = entity.Spécialité;
                edit.Statut = entity.Statut;
                edit.AjouterPar = entity.AjouterPar;
                edit.AjouterAu = entity.AjouterAu;
                edit.ModifierPar = entity.ModifierPar;
                edit.ModifierAu = entity.ModifierAu;

                db.Entry(edit).State = EntityState.Modified;
                result = Save();
            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(Specialities entity)
        {
            int result = 0;
            if (entity.Id == 0)
            {
                db.Entry(entity).State = EntityState.Added;
                db.Specialities.Add(entity);
                result = await SaveAsync();
            }
            else
            {
                var edit = await GetByIdAsync(entity).ConfigureAwait(false);
                edit.Spécialité = entity.Spécialité;
                edit.Statut = entity.Statut;
                edit.AjouterPar = entity.AjouterPar;
                edit.AjouterAu = entity.AjouterAu;
                edit.ModifierPar = entity.ModifierPar;
                edit.ModifierAu = entity.ModifierAu;

                db.Entry(edit).State = EntityState.Modified;
                result = await SaveAsync();
            }
            return result;
        }
    }
}
