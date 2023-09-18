using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class StockAlertRepository : IStockAlertRepository
    {
        public Task<int> AddAsync(StockAlert entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<StockAlert>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StockAlert> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(StockAlert entity)
        {
            throw new NotImplementedException();
        }
    }
}
