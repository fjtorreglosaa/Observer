using Microsoft.AspNetCore.Mvc;
using Observer.Application.Features.WarehouseFeatures.Commands.CreateWarehouse;
using Observer.Application.Features.WarehouseFeatures.Queries.GetAllWarehouses;

namespace Observer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : AbstractController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllWarehouses()
        {
            var result = await Mediator.Send(new GetAllWarehousesQuery());

            return Ok(result);
        }

        [HttpPost("[action]", Name = "CreateWarehouse")]
        public async Task<IActionResult> CreateWarehouse([FromBody] CreateWarehouseCommand model)
        {
            await Mediator.Send(model);

            return Ok("Warehouse created");
        }
    }
}
