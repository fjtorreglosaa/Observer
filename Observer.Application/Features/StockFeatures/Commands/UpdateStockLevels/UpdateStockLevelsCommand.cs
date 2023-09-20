using MediatR;
using Observer.Application.Utilities.DTOs.Arrival;

namespace Observer.Application.Features.StockFeatures.Commands.UpdateStockLevels
{
    public class UpdateStockLevelsCommand : IRequest
    {
        public IncomingArrivalDto Arrival { get; set; }
    }
}
