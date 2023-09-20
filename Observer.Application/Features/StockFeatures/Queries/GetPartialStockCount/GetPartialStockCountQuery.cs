using MediatR;
using Observer.Application.Utilities.DTOs.Stock;

namespace Observer.Application.Features.StockFeatures.Queries.GetPartialStockCount
{
    public class GetPartialStockCountQuery : IRequest<List<ParcialStockCountDto>>
    {
        public Guid StoreId { get; set; }
    }
}
