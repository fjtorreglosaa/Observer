using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public StockRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(Stock entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Stocks"" 
                        (
                            ""Id"", 
                            ""CreatedDate"", 
                            ""LastModified"", 
                            ""CreatedBy"", 
                            ""ModifiedBy"", 
                            ""StoreId"", 
                            ""Name"", 
                            ""ItemId"", 
                            ""Quantity"", 
                            ""MinimumStock"", 
                            ""LastDiscounted"", 
                            ""TimesDiscounted"", 
                            ""DiscountedItemsPerUpdateAvg""
                        ) 
                        VALUES 
                        (
                            @Id, 
                            @CreatedDate, 
                            @LastModified, 
                            @CreatedBy, 
                            @ModifiedBy, 
                            @StoreId, 
                            @Name, 
                            @ItemId, 
                            @Quantity, 
                            @MinimumStock, 
                            @LastDiscounted, 
                            @TimesDiscounted, 
                            @DiscountedItemsPerUpdateAvg
                        )"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Stocks"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Stock>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Stocks""";
            var result = await _connection.QueryAsync<Stock>(sql);
            return result.ToList();
        }

        public async Task<Stock> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Stocks"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<Stock>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Stock entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Stocks"" SET 
                        ""LastModified"" = @LastModified, 
                        ""ModifiedBy"" = @ModifiedBy, 
                        ""StoreId"" = @StoreId, 
                        ""Name"" = @Name, 
                        ""ItemId"" = @ItemId, 
                        ""Quantity"" = @Quantity, 
                        ""MinimumStock"" = @MinimumStock, 
                        ""LastDiscounted"" = @LastDiscounted, 
                        ""TimesDiscounted"" = @TimesDiscounted, 
                        ""DiscountedItemsPerUpdateAvg"" = @DiscountedItemsPerUpdateAvg 
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Stock>> GetStockByStoreIdsAsync(string ids)
        {
            var sql = $@"SELECT * FROM ""Stocks"" WHERE ""StoreId"" IN {ids}";
            var result = await _connection.QueryAsync<Stock>(sql); ;
            return result.ToList();
        }
    }
}
