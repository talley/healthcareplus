using HCP.Fr.DS.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public class ExceptionLogsRepository : IRepository<ExceptionLogs>
    {
        private HCPFR_LogsEntities db=new HCPFR_LogsEntities();
        public int Delete(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public int Disable(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DisableAsync(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public int Enable(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> EnableAsync(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForInsert(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public bool EnsureModelIsValidForUpdate(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public List<ExceptionLogs> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<ExceptionLogs>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ExceptionLogs GetById(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public Task<ExceptionLogs> GetByIdAsync(ExceptionLogs entity)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
           return db.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public int SaveOrUpdate(ExceptionLogs entity)
        {
            int result = 0;
            if (entity.Id == 0)
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                db.ExceptionLogs.Add(entity);
                result = Save();
            }
            return result;
        }

        public async Task<int> SaveOrUpdateAsync(ExceptionLogs entity)
        {
            int result = 0;
            if (entity.Id == 0)
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                db.ExceptionLogs.Add(entity);
                result =await SaveAsync().ConfigureAwait(false);
            }
            return result;
        }
    }
}
