using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class ArrivalRepository : IArrivalRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _sqlConnection;

        public ArrivalRepository(IDbConnection sqlConnection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _sqlConnection = sqlConnection;
        }

        public async Task<int> AddAsync(Arrival entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Arrivals"" 
                        (
                            ""Id"", 
                            ""CreatedDate"", 
                            ""LastModified"", 
                            ""CreatedBy"", 
                            ""ModifiedBy"", 
                            ""Type"", 
                            ""CompanyId"", 
                            ""ItemId"", 
                            ""BoxQuantity"", 
                            ""ItemsPerBox"", 
                            ""PalletQuantity""
                        ) 
                        VALUES 
                        (
                            @Id, 
                            @CreatedDate, 
                            @LastModified, 
                            @CreatedBy, 
                            @ModifiedBy, 
                            @Type, 
                            @CompanyId, 
                            @ItemId, 
                            @BoxQuantity, 
                            @ItemsPerBox, 
                            @PalletQuantity
                        )"
            ;

            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Arrivals"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Arrival>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Arrivals""";
            var result = await _sqlConnection.QueryAsync<Arrival>(sql);
            return result.ToList();
        }

        public async Task<Arrival> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Arrivals"" WHERE ""Id"" = @Id";
            var result = await _sqlConnection.QuerySingleOrDefaultAsync<Arrival>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Arrival entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Arrivals"" 
                     SET 
                        ""LastModified"" = @LastModified, 
                        ""ModifiedBy"" = @ModifiedBy, 
                        ""Type"" = @Type, 
                        ""CompanyId"" = @CompanyId, 
                        ""ItemId"" = @ItemId, 
                        ""BoxQuantity"" = @BoxQuantity, 
                        ""ItemsPerBox"" = @ItemsPerBox, 
                        ""PalletQuantity"" = @PalletQuantity 
                     WHERE ""Id"" = @Id";

            var result = await _sqlConnection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
