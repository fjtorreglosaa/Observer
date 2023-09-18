using MediatR;

namespace Observer.Application.Features.WarehouseFeatures.Commands.CreateWarehouse
{
    public class CreateWarehouseCommand : IRequest
    {
        public Guid? UserId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Identifier { get; set; }
    }
}
