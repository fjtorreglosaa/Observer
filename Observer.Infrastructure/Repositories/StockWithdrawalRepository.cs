using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockWithdrawalRepository : IStockWithdrawalRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public StockWithdrawalRepository(IDbConnection sqlConnection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = sqlConnection;
        }

        public async Task<int> AddAsync(StockWithdrawal entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""StockWithdrawals"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""StockId"", ""WithdrawalId"", ""Reason"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @StockId, @WithdrawalId, @Reason)"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""StockWithdrawals"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<StockWithdrawal>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""StockWithdrawals""";
            var result = await _connection.QueryAsync<StockWithdrawal>(sql);
            return result.ToList();
        }

        public async Task<StockWithdrawal> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""StockWithdrawals"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<StockWithdrawal>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(StockWithdrawal entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""StockWithdrawals"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""StockId"" = @StockId, ""WithdrawalId"" = @WithdrawalId, ""Reason"" = @Reason 
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
