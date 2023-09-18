using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class AlertRepository : IAlertRepository
    {
        public Task<int> AddAsync(Alert entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Alert>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Alert> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Alert entity)
        {
            throw new NotImplementedException();
        }
    }
}
