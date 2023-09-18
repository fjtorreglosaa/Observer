using AutoMapper;
using MediatR;
using Observer.Application.Utilities.DTOs.Warehouse;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Features.WarehouseFeatures.Queries.GetAllWarehouses
{
    public class GetAllWarehousesQueryHandler : IRequestHandler<GetAllWarehousesQuery, List<WarehouseDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllWarehousesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<WarehouseDto>> Handle(GetAllWarehousesQuery request, CancellationToken cancellationToken)
        {
            using (var context = _unitOfWork.Create())
            {
                var data = await context.Repositories.Warehouses.GetAllAsync();

                var result = _mapper.Map<List<WarehouseDto>>(data.ToList());

                return result;
            }
        }
    }
}
