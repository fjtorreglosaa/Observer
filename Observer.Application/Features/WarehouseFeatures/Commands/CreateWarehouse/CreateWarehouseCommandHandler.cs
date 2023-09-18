using MediatR;
using Observer.Domain.Entities;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Features.WarehouseFeatures.Commands.CreateWarehouse
{
    public class CreateWarehouseCommandHandler : IRequestHandler<CreateWarehouseCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateWarehouseCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateWarehouseCommand request, CancellationToken cancellationToken)
        {
            using (var context = _unitOfWork.Create())
            {
                var warehouse = new Warehouse
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.UtcNow,
                    LastModified = DateTime.UtcNow,
                    CreatedBy = request.UserId,
                    ModifiedBy = request.UserId,
                    Name = request.Name,
                    Identifier = request.Identifier,
                    Description = request.Description
                };

                await context.Repositories.Warehouses.AddAsync(warehouse);

                context.Commit();
            }
        }
    }
}
