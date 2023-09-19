using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class AisleRepository : IAisleRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public AisleRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(Aisle entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Aisles"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""WarehouseId"", ""Identifier"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @WarehouseId, @Identifier)"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Aisles"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Aisle>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Aisles""";
            var result = await _connection.QueryAsync<Aisle>(sql);
            return result.ToList();
        }

        public async Task<Aisle> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Aisles"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<Aisle>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Aisle entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Aisles"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""WarehouseId"" = @WarehouseId, ""Identifier"" = @Identifier 
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
