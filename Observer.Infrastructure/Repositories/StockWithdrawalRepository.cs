using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class StockWithdrawalRepository : IStockWithdrawalRepository
    {
        public Task<int> AddAsync(StockWithdrawal entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<StockWithdrawal>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StockWithdrawal> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(StockWithdrawal entity)
        {
            throw new NotImplementedException();
        }
    }
}
