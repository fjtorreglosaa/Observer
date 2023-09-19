using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockAlertRepository : IStockAlertRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public StockAlertRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(StockAlert entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""StockAlerts"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""StockId"", ""AlertId"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @StockId, @AlertId)"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""StockAlerts"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<StockAlert>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""StockAlerts""";
            var result = await _connection.QueryAsync<StockAlert>(sql);
            return result.ToList();
        }

        public async Task<StockAlert> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""StockAlerts"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<StockAlert>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(StockAlert entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""StockAlerts"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""StockId"" = @StockId, ""AlertId"" = @AlertId 
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
