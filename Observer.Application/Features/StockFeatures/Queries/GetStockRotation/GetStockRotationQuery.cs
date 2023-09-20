using MediatR;
using Observer.Application.Utilities.DTOs.Stock;

namespace Observer.Application.Features.StockFeatures.Queries.GetStockRotation
{
    public class GetStockRotationQuery : IRequest<List<StockInPlaceDto>>
    {
        public Guid StoreId { get; set; }
    }
}
