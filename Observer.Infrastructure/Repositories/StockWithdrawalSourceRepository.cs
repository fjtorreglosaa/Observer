using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockWithdrawalSourceRepository : IStockWithdrawalSourceRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public StockWithdrawalSourceRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(StockWithdrawalSource entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""StockWithdrawalSources"" 
                        (
                            ""Id"", 
                            ""CreatedDate"", 
                            ""LastModified"", 
                            ""CreatedBy"", 
                            ""ModifiedBy"", 
                            ""StockWithdrawalId"", 
                            ""PositionId""
                        ) 
                        VALUES 
                        (
                            @Id, 
                            @CreatedDate, 
                            @LastModified, 
                            @CreatedBy, 
                            @ModifiedBy, 
                            @StockWithdrawalId, 
                            @PositionId
                        )"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""StockWithdrawalSources"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<StockWithdrawalSource>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""StockWithdrawalSources""";
            var result = await _connection.QueryAsync<StockWithdrawalSource>(sql);
            return result.ToList();
        }

        public async Task<StockWithdrawalSource> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""StockWithdrawalSources"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<StockWithdrawalSource>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(StockWithdrawalSource entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""StockWithdrawalSources"" SET 
                        ""LastModified"" = @LastModified, 
                        ""ModifiedBy"" = @ModifiedBy, 
                        ""StockWithdrawalId"" = @StockWithdrawalId, 
                        ""PositionId"" = @PositionId
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
