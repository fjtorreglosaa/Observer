using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.UnitOfWork.Contracts
{
    public interface IUnitOfWorkRepository
    {
        IWarehouseRepository Warehouses { get; }
    }
}
