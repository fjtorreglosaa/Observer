using MediatR;
using Observer.Application.Utilities.DTOs.Stock;

namespace Observer.Application.Features.StockFeatures.Queries.GetStockCount
{
    public class GetStockCountQuery : IRequest<List<StockCountDto>>
    {
        public List<Guid?> StoreIds { get; set; }
    }
}
