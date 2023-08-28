using HCP.Fr.DS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class RoleRepository : IRepository<Roles>
    {
        internal HcpFrEntities db=new HcpFrEntities();
        public int Delete(Roles entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Roles entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(Roles entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(Roles entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(Roles entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(Roles entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(Roles entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(Roles entity)
        {
            throw new NotImplementedException();
        }

        public List<Roles> GetAll()=>db.Roles.ToList();

        public async Task<List<Roles>> GetAllAsync()=> await db.Roles.ToListAsync().ConfigureAwait(false);

        public Roles GetById(Roles entity)
        {
            throw new NotImplementedException();
        }

        public Task<Roles> GetByIdAsync(Roles entity)
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

        public int SaveOrUpdate(Roles entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveOrUpdateAsync(Roles entity)
        {
            throw new NotImplementedException();
        }
    }
}
