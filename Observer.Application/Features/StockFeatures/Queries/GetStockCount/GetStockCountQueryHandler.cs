using MediatR;
using Observer.Infrastructure.UnitOfWork.Contracts;

namespace Observer.Application.Features.StockFeatures.Queries.GetStockCount
{
    public class GetStockCountQueryHandler : IRequestHandler<GetStockCountQuery, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetStockCountQueryHandler(IUnitOfWork unitOfOfWork)
        {
            _unitOfWork = unitOfOfWork;
        }

        public async Task<int> Handle(GetStockCountQuery request, CancellationToken cancellationToken)
        {
            using (var context = _unitOfWork.Create())
            {
                //var ids = string.Join(", ", request.WarehouseIds.Select(qs => $"'{qs}'"));
                var stock = await context.Repositories.Stocks.GetAllAsync();

                if (stock.Any())
                {
                    var groupedStock = stock.GroupBy(x => x.Id).ToList();
                }

                return 1;
            }
        }
    }
}
