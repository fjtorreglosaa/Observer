using Observer.Infrastructure.Repositories;
using Observer.Infrastructure.Repositories.Contracts;
using Observer.Infrastructure.UnitOfWork.Contracts;
using System.Data;

namespace Observer.Infrastructure.UnitOfWork
{
    internal class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        public IWarehouseRepository Warehouses { get; set; }

        public UnitOfWorkRepository(IDbConnection connection, IDbTransaction transaction)
        {
            Warehouses = new WarehouseRepository(connection, transaction);
        }
    }
}
