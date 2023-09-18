using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class BayRepository : IBayRepository
    {
        public Task<int> AddAsync(Bay entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Bay>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Bay> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Bay entity)
        {
            throw new NotImplementedException();
        }
    }
}
