using Dapper;
using Observer.Domain.Entities;
using Observer.Domain.Models;
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

        public async Task<IReadOnlyList<Stock>> GetStockByItemIdsAsync(string ids)
        {
            var sql = $@"SELECT * FROM ""Stocks"" WHERE ""ItemId"" IN {ids}";
            var result = await _connection.QueryAsync<Stock>(sql); ;
            return result.ToList();
        }

        public async Task<IReadOnlyList<Stock>> GetStockByStoreIdAsync(Guid storeId)
        {
            var sql = $@"SELECT * FROM ""Stocks"" WHERE ""StoreId"" = @StoreId";
            var result = await _connection.QueryAsync<Stock>(sql, new { StoreId = storeId }, _transaction);
            return result.ToList();
        }

        public async Task<IReadOnlyList<StockInPlace>> GetStockInPlace(Guid storeId)
        {
            var sql = $@"select 
	                        s.""ItemId"" as ""ItemId"",
	                        s.""Id"" as ""StockId"",
	                        p.""Id"" as ""PositionId"",
	                        concat
                                (w.""Identifier"",' - ', a.""Identifier"",' - ', b.""Identifier"",' - ',l.""Identifier"",' - ',p.""Identifier"") 
                                as ""Identifier"",
	                        s.""LastDiscounted"" as ""LastDiscounted""
                        from ""Warehouses"" w 
                        inner join ""Aisles"" a on w.""Id"" = a.""WarehouseId""
                        inner join ""Bays"" b on a.""Id"" = b.""AisleId"" 
                        inner join ""Levels"" l on b.""Id"" = l.""BayId"" 
                        inner join ""Positions"" p on l.""Id"" = p.""LevelId"" 
                        inner join ""StockPositions"" sp on p.""Id"" = sp.""PositionId"" 
                        inner join ""Stocks"" s on sp.""StockId"" = s.""Id"" 
                        where s.""StoreId"" = @StoreId";

            var result = await _connection.QueryAsync<StockInPlace>(sql, new { StoreId = storeId }, _transaction);
            return result.ToList();
        }

        public async Task<IReadOnlyList<Stock>> GetStockByItemIdAsync(Guid itemId)
        {
            var sql = $@"SELECT * FROM ""Stocks"" WHERE ""ItemId"" = @ItemId";
            var result = await _connection.QueryAsync<Stock>(sql, new { ItemId = itemId }, _transaction);
            return result.ToList();
        }
    }
}
