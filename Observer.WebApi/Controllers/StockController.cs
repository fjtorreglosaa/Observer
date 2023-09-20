using Microsoft.AspNetCore.Mvc;
using Observer.Application.Features.StockFeatures.Commands.UpdateStockLevels;
using Observer.Application.Features.StockFeatures.Queries.GetPartialStockCount;
using Observer.Application.Features.StockFeatures.Queries.GetTotalStockCount;
using Observer.Application.Publishers.Contracts;
using Observer.Application.Utilities.DTOs.Arrival;

namespace Observer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : AbstractController
    {
        private readonly IStockLevelService _stockLevelService;
        private readonly IStockArrivalSubscriber _stockArrival;
        private readonly IStockCheckoutSubscriber _stockCheckout;

        public StockController(
            IStockLevelService stockLevelService,
            IStockArrivalSubscriber stockArrival,
            IStockCheckoutSubscriber stockCheckout)
        {
            _stockLevelService = stockLevelService;
            _stockArrival = stockArrival;
            _stockCheckout = stockCheckout;
        }

        [HttpGet("[action]/{storeId}")]
        public async Task<IActionResult> GetTotalStockCount(Guid storeId)
        {
            var result = await Mediator.Send(new GetPartialStockCountQuery { StoreId = storeId });

            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetTotalStockCount([FromQuery] List<Guid?> storeIds)
        {
            var result = await Mediator.Send(new GetTotalStockCountQuery { StoreIds = storeIds });

            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ProcessIncomingStock([FromBody] IncomingArrivalDto arrivalData)
        {
            var command = new UpdateStockLevelsCommand { Arrival = arrivalData };

            await Mediator.Send(command);

            return Ok("The arrival has been processed");
        }
    }
}
