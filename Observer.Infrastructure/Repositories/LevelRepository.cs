using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _sqlConnection;

        public LevelRepository(IDbConnection sqlConnection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _sqlConnection = sqlConnection;
        }

        public async Task<int> AddAsync(Level entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Levels"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""BayId"", ""Identifier"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @BayId, @Identifier)"
            ;

            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Levels"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Level>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Levels""";
            var result = await _sqlConnection.QueryAsync<Level>(sql);
            return result.ToList();
        }

        public async Task<Level> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Levels"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.QuerySingleOrDefaultAsync<Level>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Level entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Levels"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""BayId"" = @BayId, ""Identifier"" = @Identifier 
                     WHERE ""Id"" = @Id";
            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
