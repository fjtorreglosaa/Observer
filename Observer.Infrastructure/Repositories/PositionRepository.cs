using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _sqlConnection;

        public PositionRepository(IDbConnection sqlConnection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _sqlConnection = sqlConnection;
        }
        public async Task<int> AddAsync(Position entity)
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
        public async Task<IReadOnlyList<Position>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Warehouses""";
            var result = await _sqlConnection.QueryAsync<Position>(sql);
            return result.ToList();
        }
        public async Task<Position> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Warehouses"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.QuerySingleOrDefaultAsync<Position>(sql, new { Id = id }, _transaction);
            return result;
        }
        public async Task<int> UpdateAsync(Position entity)
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
