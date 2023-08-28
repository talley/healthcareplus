using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class UserStatusesRepository : IRepository<UserStatuses>
    {
        internal HcpFrEntities db=new HcpFrEntities();
        public int Delete(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public List<UserStatuses> GetAll()=>db.UserStatuses.AsParallel().ToList();

        public async Task<List<UserStatuses>> GetAllAsync() => await db.UserStatuses.ToListAsync().ConfigureAwait(false);

        public UserStatuses GetById(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public Task<UserStatuses> GetByIdAsync(UserStatuses entity)
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

        public int SaveOrUpdate(UserStatuses entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveOrUpdateAsync(UserStatuses entity)
        {
            throw new NotImplementedException();
        }
    }
}
