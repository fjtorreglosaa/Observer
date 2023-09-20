using AutoMapper;
using MediatR;
using Observer.Application.Utilities.DTOs.Stock;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Features.StockFeatures.Queries.GetStockRotation
{
    public class GetStockRotationQueryHandler : IRequestHandler<GetStockRotationQuery, List<StockInPlaceDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStockRotationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<StockInPlaceDto>> Handle(GetStockRotationQuery request, CancellationToken cancellationToken)
        {
            using (var context = _unitOfWork.Create())
            {
                var stockInPlace = await context.Repositories.Stocks.GetStockInPlace(request.StoreId);

                var result = _mapper.Map<List<StockInPlaceDto>>(stockInPlace.ToList());

                return result;
            }
        }
    }
}
