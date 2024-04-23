using Library.Firebase.Repository.Entities;

namespace Library.Firebase.Repository
{
    public interface IFirebaseRepository<T> where T : IBaseEntity
    {
        Task<T> GetAsync(string key);
        Task<IEnumerable<T>> GetAllAsync();
        Task<string> CreateAsync(T entity);
        Task UpdateAsync(string key, T entity);
        Task DeleteAsync(string key);
    }
}
