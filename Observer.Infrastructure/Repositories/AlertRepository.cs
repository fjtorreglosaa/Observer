using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class AlertRepository : IAlertRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public AlertRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(Alert entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Alerts"" (""Id"", ""CreatedDate"", ""LastModified"", ""CreatedBy"", ""ModifiedBy"", ""Name"", ""Description"", ""Type"") 
                        VALUES (@Id, @CreatedDate, @LastModified, @CreatedBy, @ModifiedBy, @Name, @Description, @Type)"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Alerts"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Alert>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Alerts""";
            var result = await _connection.QueryAsync<Alert>(sql);
            return result.ToList();
        }

        public async Task<Alert> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Alerts"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<Alert>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Alert entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Alerts"" 
                     SET ""LastModified"" = @LastModified, ""ModifiedBy"" = @ModifiedBy, ""Name"" = @Name, ""Description"" = @Description, ""Type"" = @Type 
                     WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
