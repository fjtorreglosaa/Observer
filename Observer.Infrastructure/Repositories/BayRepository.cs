using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class BayRepository : IBayRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public BayRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(Bay entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Bays"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""AisleId"", ""Identifier"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @AisleId, @Identifier)"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Bays"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Bay>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Bays""";
            var result = await _connection.QueryAsync<Bay>(sql);
            return result.ToList();
        }

        public async Task<Bay> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Bays"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<Bay>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Bay entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Bays"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""AisleId"" = @AisleId, ""Identifier"" = @Identifier 
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
