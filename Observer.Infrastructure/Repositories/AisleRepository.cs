using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class AisleRepository : IAisleRepository
    {
        public Task<int> AddAsync(Aisle entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Aisle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Aisle> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Aisle entity)
        {
            throw new NotImplementedException();
        }
    }
}
