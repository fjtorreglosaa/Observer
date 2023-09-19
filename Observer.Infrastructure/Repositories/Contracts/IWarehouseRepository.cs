using Observer.Domain.Entities;

namespace Observer.Infrastructure.Repositories.Contracts
{
    public interface IWarehouseRepository : IGenericRepository<Warehouse>
    {
        Task<IReadOnlyList<Warehouse>> GetWarehouseByIds(string warehouseIds);
    }
}
