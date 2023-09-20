using MediatR;
using Observer.Application.Utilities.DTOs.Stock;

namespace Observer.Application.Features.StockFeatures.Queries.GetTotalStockCount
{
    public class GetTotalStockCountQuery : IRequest<List<TotalStockCountDto>>
    {
        public List<Guid?> StoreIds { get; set; }
    }
}
