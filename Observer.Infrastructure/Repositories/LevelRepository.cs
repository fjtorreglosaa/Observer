using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        public Task<int> AddAsync(Level entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Level>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Level> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Level entity)
        {
            throw new NotImplementedException();
        }
    }
}
