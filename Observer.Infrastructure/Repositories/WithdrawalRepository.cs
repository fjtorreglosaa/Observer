using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class WithdrawalRepository : IWithdrawalRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public WithdrawalRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(Withdrawal entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Withdrawals"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""Type"", ""Description"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @Type, @Description)"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Withdrawals"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Withdrawal>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Withdrawals""";
            var result = await _connection.QueryAsync<Withdrawal>(sql);
            return result.ToList();
        }

        public async Task<Withdrawal> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Withdrawals"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<Withdrawal>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Withdrawal entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Withdrawals"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""Type"" = @Type, ""Description"" = @Description 
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
