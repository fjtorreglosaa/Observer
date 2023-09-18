using Observer.Domain.Entities;

namespace Observer.Infrastructure.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : Entity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(Guid id);
    }
}
