using MediatR;
using Observer.Application.Utilities.DTOs.Stock;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Features.StockFeatures.Queries.GetStockCount
{
    public class GetStockCountQueryHandler : IRequestHandler<GetStockCountQuery, List<StockCountDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetStockCountQueryHandler(IUnitOfWork unitOfOfWork)
        {
            _unitOfWork = unitOfOfWork;
        }

        public async Task<List<StockCountDto>> Handle(GetStockCountQuery request, CancellationToken cancellationToken)
        {
            using (var context = _unitOfWork.Create())
            {
                var ids = string.Join(", ", request.StoreIds.Select(qs => $"'{qs}'"));
                var stock = await context.Repositories.Stocks.GetStockByStoreIdsAsync($"({ids})");

                if (stock.Any())
                {
                    var items = stock
                            .GroupBy(x => x.ItemId)
                            .Select(x => new StockCountDto
                            {
                                ItemId = x.Key,
                                StockQuantity = x.Sum(y => y.Quantity)
                            });

                    foreach (var item in items)
                    {
                        if (item.StockQuantity <= 5)
                        {

                        }
                    }

                    return items.ToList();
                }

                return null;
            }
        }
    }
}
