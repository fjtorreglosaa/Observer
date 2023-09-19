using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockPositionRepository : IStockPositionRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public StockPositionRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(StockPosition entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""StockPositions"" 
                        (
                            ""Id"", 
                            ""CreatedDate"", 
                            ""LastModified"", 
                            ""CreatedBy"", 
                            ""ModifiedBy"", 
                            ""StockId"", 
                            ""PositionId""
                        ) 
                        VALUES 
                        (
                            @Id, 
                            @CreatedDate, 
                            @LastModified, 
                            @CreatedBy, 
                            @ModifiedBy, 
                            @StockId, 
                            @PositionId
                        )"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""StockPositions"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<StockPosition>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""StockPositions""";
            var result = await _connection.QueryAsync<StockPosition>(sql);
            return result.ToList();
        }

        public async Task<StockPosition> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""StockPositions"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<StockPosition>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(StockPosition entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""StockPositions"" SET 
                        ""LastModified"" = @LastModified, 
                        ""ModifiedBy"" = @ModifiedBy, 
                        ""StockId"" = @StockId, 
                        ""PositionId"" = @PositionId
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
