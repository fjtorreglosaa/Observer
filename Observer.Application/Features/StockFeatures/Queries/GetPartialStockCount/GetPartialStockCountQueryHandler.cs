using AutoMapper;
using MediatR;
using Observer.Application.Utilities.DTOs.Stock;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Features.StockFeatures.Queries.GetPartialStockCount
{
    public class GetPartialStockCountQueryHandler : IRequestHandler<GetPartialStockCountQuery, List<ParcialStockCountDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPartialStockCountQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ParcialStockCountDto>> Handle(GetPartialStockCountQuery request, CancellationToken cancellationToken)
        {
            using (var context = _unitOfWork.Create())
            {
                var stock = await context.Repositories.Stocks.GetStockByStoreIdAsync(request.StoreId);

                if (stock.Any())
                {
                    var result = _mapper.Map<List<ParcialStockCountDto>>(stock.ToList());

                    return result;
                }

                return null;
            }
        }
    }
}
