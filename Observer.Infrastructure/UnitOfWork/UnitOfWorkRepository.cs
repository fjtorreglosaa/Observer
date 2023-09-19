using Observer.Infrastructure.Repositories;
using Observer.Infrastructure.Repositories.Contracts;
using Observer.Infrastructure.UnitOfWork.Contracts;
using System.Data;

namespace Observer.Infrastructure.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        public IAisleRepository Aisles { get; set; }
        public IAlertRepository Alerts { get; set; }
        public IArrivalRepository Arrivals { get; set; }
        public IBayRepository Bays { get; set; }
        public ILevelRepository Levels { get; set; }
        public IPositionRepository Positions { get; set; }
        public IStockRepository Stocks { get; set; }
        public IStockAlertRepository StockAlerts { get; set; }
        public IStockArrivalRepository StockArrivals { get; set; }
        public IStockPositionRepository StockPositions { get; set; }
        public IStockWithdrawalRepository StockWithdrawals { get; set; }
        public IStockWithdrawalSourceRepository StockWithdrawalSources { get; set; }
        public IWarehouseRepository Warehouses { get; set; }
        public IWithdrawalRepository Withdrawals { get; set; }

        public UnitOfWorkRepository(IDbConnection connection, IDbTransaction transaction)
        {
            Aisles = new AisleRepository(connection, transaction);
            Alerts = new AlertRepository(connection, transaction);
            Arrivals = new ArrivalRepository(connection, transaction);
            Bays = new BayRepository(connection, transaction);
            Levels = new LevelRepository(connection, transaction);
            Positions = new PositionRepository(connection, transaction);
            Stocks = new StockRepository(connection, transaction);
            StockAlerts = new StockAlertRepository(connection, transaction);
            StockArrivals = new StockArrivalRepository(connection, transaction);
            StockPositions = new StockPositionRepository(connection, transaction);
            StockWithdrawals = new StockWithdrawalRepository(connection, transaction);
            StockWithdrawalSources = new StockWithdrawalSourceRepository(connection, transaction);
            Warehouses = new WarehouseRepository(connection, transaction);
            Withdrawals = new WithdrawalRepository(connection, transaction);
        }
    }
}
