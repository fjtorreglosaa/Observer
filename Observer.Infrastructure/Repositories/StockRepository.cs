using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _sqlConnection;

        public StockRepository(IDbConnection sqlConnection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _sqlConnection = sqlConnection;
        }
        public async Task<int> AddAsync(Stock entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Warehouses"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""Name"", ""Description"", ""Identifier"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @Name, @Description, @Identifier)"
            ;

            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Warehouses"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }
        public async Task<IReadOnlyList<Stock>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Warehouses""";
            var result = await _sqlConnection.QueryAsync<Stock>(sql);
            return result.ToList();
        }
        public async Task<Stock> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Warehouses"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.QuerySingleOrDefaultAsync<Stock>(sql, new { Id = id }, _transaction);
            return result;
        }
        public async Task<int> UpdateAsync(Stock entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Warehouses"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""Name"" = @Name, ""Description"" = @Description, ""Identifier"" = @Identifier 
                     WHERE ""Id"" = @Id";
            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
