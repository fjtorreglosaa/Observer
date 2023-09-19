using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Observer.Application.Features.StockFeatures.Queries.GetStockCount;
using Observer.Application.Features.WarehouseFeatures.Queries.GetAllWarehouses;

namespace Observer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : AbstractController
    {
        [HttpGet]
        public async Task<IActionResult> GetStockCount([FromQuery] List<Guid?> storeIds)
        {
            var result = await Mediator.Send(new GetStockCountQuery { StoreIds = storeIds });

            return Ok(result);
        }
    }
}
