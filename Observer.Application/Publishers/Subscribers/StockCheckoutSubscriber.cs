using Observer.Application.Publishers.Contracts;
using Observer.Application.Utilities.AlertStates;
using Observer.Domain.Entities;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Publishers.Subscribers
{
    public class StockCheckoutSubscriber : IStockCheckoutSubscriber
    {
        private readonly IUnitOfWork _unitOfWork;

        public StockCheckoutSubscriber(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Update(IAlertPublisher publisher, Guid stockId, Guid alertId)
        {
            using (var context = _unitOfWork.Create())
            {
                var stock = await context.Repositories.Stocks.GetByIdAsync(stockId);
                var alert = await context.Repositories.Alerts.GetByIdAsync(alertId);

                if ((publisher as StockLevelService).State == (int)AlertPublisherStates.PARTIAL_STOCK ||
                    (publisher as StockLevelService).State == (int)AlertPublisherStates.TOTAL_STOCK)
                {
                    if (stockId != null && alertId != null)
                    {
                        var newAlert = new StockAlert
                        {
                            Id = Guid.NewGuid(),
                            CreatedDate = DateTime.Now,
                            StockId = stockId,
                            AlertId = alertId
                        };

                        await context.Repositories.StockAlerts.AddAsync(newAlert);

                        // Generar una pre-orden de nuevo inventario para rellenar el faltante bajo cierta logica de negocio
                    }
                }

                context.Commit();
            }
        }
    }
}
