using MediatR;
using Observer.Application.Publishers.Contracts;

namespace Observer.Application.Features.StockFeatures.Commands.UpdateStockLevels
{
    public class UpdateStockLevelsCommandHandler : IRequestHandler<UpdateStockLevelsCommand>
    {
        private readonly IStockLevelService _stockLevelService;
        private readonly IStockArrivalSubscriber _stockArrival;
        private readonly IStockCheckoutSubscriber _stockCheckout;

        public UpdateStockLevelsCommandHandler(
            IStockLevelService stockLevelService,
            IStockArrivalSubscriber stockArrival,
            IStockCheckoutSubscriber stockCheckout)
        {
            _stockLevelService = stockLevelService;
            _stockArrival = stockArrival;
            _stockCheckout = stockCheckout;
        }

        public async Task Handle(UpdateStockLevelsCommand request, CancellationToken cancellationToken)
        {
            _stockLevelService.Attach(_stockArrival);
            _stockLevelService.Attach(_stockCheckout);
            await _stockLevelService.ProcessArrival(request.Arrival);
            _stockLevelService.Detach(_stockArrival);

            await _stockLevelService.CheckStock(new List<Guid?> { request.Arrival.StoreId });
        }
    }
}
