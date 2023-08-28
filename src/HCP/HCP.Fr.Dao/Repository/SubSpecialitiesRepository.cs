using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class SubSpecialitiesRepository : IRepository<Sub_Specialties>
    {
        internal HcpFrEntities db = new HcpFrEntities();

        public int Delete(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public List<Sub_Specialties> GetAll()
        {
            return db.Sub_Specialties.ToList();
        }

        public async Task<List<Sub_Specialties>> GetAllAsync()
        {
            return await db.Sub_Specialties.ToListAsync().ConfigureAwait(false);
        }

        public Sub_Specialties GetById(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public Task<Sub_Specialties> GetByIdAsync(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public int SaveOrUpdate(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveOrUpdateAsync(Sub_Specialties entity)
        {
            throw new NotImplementedException();
        }
    }
}
