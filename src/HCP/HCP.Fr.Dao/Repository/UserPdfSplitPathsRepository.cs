using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class UserPdfSplitPathsRepository : IRepository<UserPdfSplitPaths>
    {
        internal HcpFrEntities db = new HcpFrEntities();

        public int Delete(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(UserPdfSplitPaths entity)
        {
            throw new NotImplementedException();
        }

        public List<UserPdfSplitPaths> GetAll()
        {
            return db.UserPdfSplitPaths.ToList();
        }

        public async Task<List<UserPdfSplitPaths>> GetAllAsync()
        {
            return await db.UserPdfSplitPaths.ToListAsync().ConfigureAwait(false);
        }

        public UserPdfSplitPaths GetById(UserPdfSplitPaths entity)
        {
            return db.UserPdfSplitPaths.SingleOrDefault(x => x.Id == entity.Id);
        }

        public async Task<UserPdfSplitPaths> GetByIdAsync(UserPdfSplitPaths entity)
        {
            return await db.UserPdfSplitPaths.SingleOrDefaultAsync(x => x.Id == entity.Id).ConfigureAwait(false);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public int SaveOrUpdate(UserPdfSplitPaths entity)
        {
            int result = 0;
            if (entity.Id == 0)
            {
                db.Entry(entity).State = EntityState.Added;
                db.UserPdfSplitPaths.Add(entity);
                result = Save();
            }
            else
            {
                var edit = GetById(entity);
                if (edit != null)
                {
                    edit.AjouterAu = entity.AjouterAu;
                    edit.AjouterPar = entity.AjouterPar;
                    edit.ModifierPar = entity.ModifierPar;
                    edit.ModifierAu = entity.ModifierAu;
                    edit.SavedPath = entity.SavedPath;
                    edit.ComputerName = entity.ComputerName;
                    edit.Email = entity.Email;
                    edit.UserName = entity.UserName;

                    db.Entry(edit).State = EntityState.Modified;
                    result = Save();
                }
            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(UserPdfSplitPaths entity)
        {
            int result = 0;
            if (entity.Id == 0)
            {
                db.Entry(entity).State = EntityState.Added;
                db.UserPdfSplitPaths.Add(entity);
                result = await SaveAsync();
            }
            else
            {
                var edit = await GetByIdAsync(entity);
                if (edit != null)
                {
                    edit.AjouterAu = entity.AjouterAu;
                    edit.AjouterPar = entity.AjouterPar;
                    edit.ModifierPar = entity.ModifierPar;
                    edit.ModifierAu = entity.ModifierAu;
                    edit.SavedPath = entity.SavedPath;
                    edit.ComputerName = entity.ComputerName;
                    edit.Email = entity.Email;
                    edit.UserName = entity.UserName;

                    db.Entry(edit).State = EntityState.Modified;
                    result = await SaveAsync();
                }
            }
            return result;
        }
    }
}
