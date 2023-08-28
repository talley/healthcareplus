using System.Collections.Generic;
using System.Threading.Tasks;

namespace HCP.Fr.Dao.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetById(T entity);
        Task<T> GetByIdAsync(T entity);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();

        int Save();
        Task<int> SaveAsync();

        int SaveOrUpdate(T entity);
        Task<int> SaveOrUpdateAsync(T entity);

        int Delete(T entity);
        Task<int> DeleteAsync(T entity);
        bool EnsureModelIsValidForInsert(T entity);
        bool EnsureModelIsValidForUpdate(T entity);

        int Disable(T entity);
        Task<int> DisableAsync(T entity);

        int Enable(T entity);
        Task<int> EnableAsync(T entity);


    }
}
