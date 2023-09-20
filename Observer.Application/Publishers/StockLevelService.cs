using MediatR;
using Observer.Application.Features.StockFeatures.Queries.GetPartialStockCount;
using Observer.Application.Features.StockFeatures.Queries.GetStockRotation;
using Observer.Application.Features.StockFeatures.Queries.GetTotalStockCount;
using Observer.Application.Publishers.Contracts;
using Observer.Application.Utilities.AlertStates;
using Observer.Application.Utilities.DTOs.Arrival;
using Observer.Domain.Entities;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Publishers
{
    public class StockLevelService : IStockLevelService
    {
        public int State { get; set; } = 0;
        private List<IAlertSubscriber> subscribers = new List<IAlertSubscriber>();
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public StockLevelService(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public void Attach(IAlertSubscriber subscriber)
        {
            Console.WriteLine("PUBLISHER: ATTACHED A SUBSCRIBER." + nameof(subscriber));
            subscribers.Add(subscriber);
        }

        public void Detach(IAlertSubscriber subscriber)
        {
            subscribers.Remove(subscriber);
            Console.WriteLine("PUBLISHER: DETACHED A SUBSCRIBER." + nameof(subscriber));
        }

        public void Notify(Guid stockId, Guid alertId)
        {
            Console.WriteLine("PUBLISHER: NOTIFYING SUBSCRIBERS...");

            foreach (var subscriber in subscribers)
            {
                subscriber.Update(this, stockId, alertId);
            }
        }

        public async Task ProcessArrival(IncomingArrivalDto data)
        {
            var ARRIVAL_ALERT_ID = Guid.Parse("9a6de3c6-8c85-4eab-931d-189c66e42ac5");

            using (var context = _unitOfWork.Create())
            {
                State = (int)AlertPublisherStates.STOCK_ARRIVAL;

                var arrival = new Arrival
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    LastModified = DateTime.Now,
                    CreatedBy = Guid.NewGuid(),
                    ModifiedBy = Guid.NewGuid(),
                    StoreId = data.StoreId,
                    SupplierId = Guid.Parse("7e3366f8-292a-456d-8963-119fb1197844"),
                    Type = "STANDARD"
                };

                await context.Repositories.Arrivals.AddAsync(arrival);

                var itemIds = string.Join(", ", data.ItemIds.Select(qs => $"'{qs}'"));
                var stocks = await context.Repositories.Stocks.GetStockByItemIdsAsync($"({itemIds})");

                foreach (var stock in stocks)
                {
                    var stockArrival = new StockArrival
                    {
                        Id = Guid.NewGuid(),
                        CreatedDate = DateTime.Now,
                        LastModified = DateTime.Now,
                        CreatedBy = Guid.NewGuid(),
                        ModifiedBy = Guid.NewGuid(),
                        BoxQuantity = 10,
                        ItemsPerBox = 10,
                        IsPalletArrival = false,
                        ArrivalId = arrival.Id,
                        StockId = stock.Id,
                        ItemId = stock.ItemId
                    };

                    var stockToAdd = stockArrival.BoxQuantity * stockArrival.ItemsPerBox;
                    stock.Quantity = stock.Quantity + stockToAdd.Value;

                    await context.Repositories.StockArrivals.AddAsync(stockArrival);
                    await context.Repositories.Stocks.UpdateAsync(stock);

                    Notify(stock.Id, ARRIVAL_ALERT_ID);
                }

                context.Commit();
            }
        }

        public async Task CheckStock(List<Guid?> stores)
        {
            var LOW_STOCK_ROTATION_ALERT_ID = Guid.Parse("d4cfd857-e4ac-4f0a-92ec-9845abb7c650");
            var TOTAL_STOCK_ALERT_ID        = Guid.Parse("9b6a9b83-7e22-4a4b-9e9f-633219c0c661");
            var PARTIAL_STOCK_ALERT_ID      = Guid.Parse("2c39738d-1020-4148-82e6-e80ce9760053");

            using (var context = _unitOfWork.Create())
            {
                var totalStock = await _mediator.Send(new GetTotalStockCountQuery { StoreIds = stores });

                foreach (var stock in totalStock)
                {
                    if (stock.StockQuantity < stock.MinAllowedStockQuantity)
                    {
                        var itemStockSources = await context.Repositories.Stocks.GetStockByItemIdAsync(stock.ItemId.Value);
                        State = (int)AlertPublisherStates.TOTAL_STOCK;
                        foreach (var itemStockSource in itemStockSources) Notify(itemStockSource.Id, TOTAL_STOCK_ALERT_ID);
                    }
                }

                foreach (var store in stores)
                {
                    var storeStock = await _mediator.Send(new GetPartialStockCountQuery { StoreId = store.Value });

                    foreach (var stock in storeStock)
                    {
                        if (stock.StockQuantity < stock.MinimumAllowedQuantity)
                        {
                            State = (int)AlertPublisherStates.PARTIAL_STOCK;
                            Notify(stock.StockId.Value, PARTIAL_STOCK_ALERT_ID);
                        }
                    }

                    var storeStockRotation = await _mediator.Send(new GetStockRotationQuery { StoreId = store.Value });

                    foreach (var stock in storeStockRotation)
                    {
                        if (stock.DaysFromLastDiscount != null && stock.DaysFromLastDiscount <= 15)
                        {
                            State = (int)AlertPublisherStates.LOW_STOCK_ROTATION;
                            Notify(stock.StockId.Value, LOW_STOCK_ROTATION_ALERT_ID);
                        }
                    }
                }
            }
        }
    }
}
