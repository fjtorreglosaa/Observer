using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        public Task<int> AddAsync(Stock entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Stock>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Stock> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Stock entity)
        {
            throw new NotImplementedException();
        }
    }
}
