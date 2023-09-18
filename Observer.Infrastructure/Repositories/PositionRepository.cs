using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        public Task<int> AddAsync(Position entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Position>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Position> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Position entity)
        {
            throw new NotImplementedException();
        }
    }
}
