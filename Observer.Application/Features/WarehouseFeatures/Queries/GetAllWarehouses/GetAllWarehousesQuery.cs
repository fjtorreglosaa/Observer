using MediatR;
using Observer.Application.Utilities.DTOs.Warehouse;

namespace Observer.Application.Features.WarehouseFeatures.Queries.GetAllWarehouses
{
    public class GetAllWarehousesQuery : IRequest<List<WarehouseDto>>
    {

    }
}
