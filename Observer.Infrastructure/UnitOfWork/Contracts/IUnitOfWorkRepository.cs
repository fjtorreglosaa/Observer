using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.UnitOfWork.Contracts
{
    public interface IUnitOfWorkRepository
    {
        IWarehouseRepository Warehouses { get; }
        IAisleRepository Aisles { get; }
        IAlertRepository Alerts { get; }
        IArrivalRepository Arrivals { get; }
        IBayRepository Bays { get; }
        ILevelRepository Levels { get; }
        IPositionRepository Positions { get; }
        IStockRepository Stocks { get; }
        IStockAlertRepository StockAlerts { get; }
        IStockArrivalRepository StockArrivals { get; }
        IStockPositionRepository StockPositions { get; }
        IStockWithdrawalRepository StockWithdrawals { get; }
        IStockWithdrawalSourceRepository StockWithdrawalSources { get; }
        IWithdrawalRepository Withdrawals { get; }
    }
}
