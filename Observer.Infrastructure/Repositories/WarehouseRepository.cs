using Azure.Core;
using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public WarehouseRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(Warehouse entity)
        {
            entity.CreatedDate = DateTime.Now;
            var sql = @"INSERT INTO ""Warehouses"" 
                        (
                            ""Id"", 
                            ""CreatedDate"", 
                            ""LastModified"", 
                            ""CreatedBy"", 
                            ""ModifiedBy"", 
                            ""Name"", 
                            ""Description"", 
                            ""Identifier"", 
                            ""Active""
                        ) 
                        VALUES 
                        (
                            @Id, 
                            @CreatedDate, 
                            @LastModified, 
                            @CreatedBy, 
                            @ModifiedBy, 
                            @Name, 
                            @Description, 
                            @Identifier, 
                            @Active
                        )"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Warehouses"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Warehouse>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Warehouses""";
            var result = await _connection.QueryAsync<Warehouse>(sql);
            return result.ToList();
        }

        public async Task<IReadOnlyList<Warehouse>> GetWarehouseByIds(string warehouseIds)
        {
            var sql = $@"SELECT * FROM ""Warehouses"" WHERE Id IN {warehouseIds}";
            var result = await _connection.QueryAsync<Warehouse>(sql);
            return result.ToList();
        }

        public async Task<Warehouse> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Warehouses"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<Warehouse>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Warehouse entity)
        {
            entity.LastModified = DateTime.Now;
            var sql = @"UPDATE ""Warehouses"" SET 
                        ""LastModified"" = @LastModified, 
                        ""ModifiedBy"" = @ModifiedBy, 
                        ""Name"" = @Name, 
                        ""Description"" = @Description, 
                        ""Identifier"" = @Identifier,  
                        ""Active"" = @Active 
                     WHERE Id = @Id";
            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
