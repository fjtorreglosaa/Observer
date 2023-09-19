using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockArrivalRepository : IStockArrivalRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public StockArrivalRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
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
                            ""IsPalletArrival""
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
                            @IsPalletArrival
                        )"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""StockArrivals"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<StockArrival>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""StockArrivals""";
            var result = await _connection.QueryAsync<StockArrival>(sql);
            return result.ToList();
        }

        public async Task<StockArrival> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""StockArrivals"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<StockArrival>(sql, new { Id = id }, _transaction);
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
                        ""IsPalletArrival"" = @IsPalletArrival  
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

    }
}
