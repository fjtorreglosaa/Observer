using Observer.Domain.Entities;
using Observer.Domain.Models;

namespace Observer.Infrastructure.Repositories.Contracts
{
    public interface IStockRepository : IGenericRepository<Stock>
    {
        Task<IReadOnlyList<Stock>> GetStockByStoreIdsAsync(string ids);
        Task<IReadOnlyList<Stock>> GetStockByStoreIdAsync(Guid storeId);
        Task<IReadOnlyList<Stock>> GetStockByItemIdAsync(Guid storeId);
        Task<IReadOnlyList<StockInPlace>> GetStockInPlace(Guid storeId);
        Task<IReadOnlyList<Stock>> GetStockByItemIdsAsync(string ids);
    }
}
