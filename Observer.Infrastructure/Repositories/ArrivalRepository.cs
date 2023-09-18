using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class ArrivalRepository : IArrivalRepository
    {
        public Task<int> AddAsync(Arrival entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Arrival>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Arrival> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Arrival entity)
        {
            throw new NotImplementedException();
        }
    }
}
