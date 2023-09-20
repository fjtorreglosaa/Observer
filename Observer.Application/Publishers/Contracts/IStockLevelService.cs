using Observer.Application.Utilities.DTOs.Arrival;

namespace Observer.Application.Publishers.Contracts
{
    public interface IStockLevelService : IAlertPublisher
    {
        Task ProcessArrival(IncomingArrivalDto data);
        Task CheckStock(List<Guid?> stores);
    }
}
