﻿using Observer.Domain.Entities;

namespace Observer.Infrastructure.Repositories.Contracts
{
    public interface IStockRepository : IGenericRepository<Stock>
    {
        Task<IReadOnlyList<Stock>> GetStockByStoreIdsAsync(string ids);
    }
}
