using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockArrivalRepository : IStockArrivalRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _sqlConnection;

        public StockArrivalRepository(IDbConnection sqlConnection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _sqlConnection = sqlConnection;
        }

        public async Task<int> AddAsync(StockArrival entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""StockArrivals"" 
                        (
                            ""Id"", 
                            ""CreatedDate"", 
                            ""LastModified"", 
                            ""CreatedBy"", 
                            ""ModifiedBy"", 
                            ""StockId"", 
                            ""ArrivalId"",
                            ""ItemId"", 
                            ""BoxQuantity"", 
                            ""ItemsPerBox"", 
                            ""PalletQuantity""
                        ) 
                        VALUES 
                        (
                            @Id, 
                            @CreatedDate, 
                            @LastModified, 
                            @CreatedBy, 
                            @ModifiedBy, 
                            @StockId, 
                            @ArrivalId, 
                            @ItemId, 
                            @BoxQuantity, 
                            @ItemsPerBox, 
                            @PalletQuantity
                        )"
            ;

            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""StockArrivals"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<StockArrival>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""StockArrivals""";
            var result = await _sqlConnection.QueryAsync<StockArrival>(sql);
            return result.ToList();
        }

        public async Task<StockArrival> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""StockArrivals"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.QuerySingleOrDefaultAsync<StockArrival>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(StockArrival entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""StockArrivals"" SET 
                        ""LastModified"" = @LastModified, 
                        ""ModifiedBy"" = @ModifiedBy, 
                        ""StockId"" = @StockId, 
                        ""ArrivalId"" = @ArrivalId, 
                        ""ItemId"" = @ItemId, 
                        ""BoxQuantity"" = @BoxQuantity, 
                        ""ItemsPerBox"" = @ItemsPerBox, 
                        ""PalletQuantity"" = @PalletQuantity  
                     WHERE ""Id"" = @Id";
            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
