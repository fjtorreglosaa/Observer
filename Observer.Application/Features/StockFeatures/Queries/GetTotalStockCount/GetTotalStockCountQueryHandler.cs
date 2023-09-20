using MediatR;
using Observer.Application.Utilities.DTOs.Stock;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Features.StockFeatures.Queries.GetTotalStockCount
{
    public class GetTotalStockCountQueryHandler : IRequestHandler<GetTotalStockCountQuery, List<TotalStockCountDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetTotalStockCountQueryHandler(IUnitOfWork unitOfOfWork)
        {
            _unitOfWork = unitOfOfWork;
        }

        public async Task<List<TotalStockCountDto>> Handle(GetTotalStockCountQuery request, CancellationToken cancellationToken)
        {
            using (var context = _unitOfWork.Create())
            {
                if (!request.StoreIds.Any()) return null;

                var ids = string.Join(", ", request.StoreIds.Select(qs => $"'{qs}'"));

                var stock = await context.Repositories.Stocks.GetStockByStoreIdsAsync($"({ids})");

                if (stock.Any())
                {
                    var items = stock
                            .GroupBy(x => x.ItemId)
                            .Select(x => new TotalStockCountDto
                            {
                                ItemId = x.Key,
                                StockQuantity = x.Sum(y => y.Quantity),
                                MinAllowedStockQuantity = x.Sum(y => y.MinimumStock)
                            }).ToList();

                    return items;
                }

                return null;
            }
        }
    }
}
