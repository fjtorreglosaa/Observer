using Dapper;
using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories.Contracts;
using System.Data;

namespace Observer.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly IDbTransaction _transaction;
        private readonly IDbConnection _connection;

        public PositionRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _transaction = transaction;
            _connection = connection;
        }

        public async Task<int> AddAsync(Position entity)
        {
            entity.CreatedDate = DateTime.Now;

            var sql = @"INSERT INTO ""Positions"" 
                        (
                            ""Id"", 
                            ""CreatedDate"", 
                            ""LastModified"", 
                            ""CreatedBy"", 
                            ""ModifiedBy"", 
                            ""Identifier"", 
                            ""Height"", 
                            ""Width"", 
                            ""Depth"", 
                            ""MaxCapacity"", 
                            ""Type"", 
                            ""LevelId"", 
                            ""Empty"",
                            ""Reserved"",
                            ""Active"",
                            ""DateReserved""
                        ) 
                        VALUES 
                        (
                            @Id, 
                            @CreatedDate, 
                            @LastModified, 
                            @CreatedBy, 
                            @ModifiedBy, 
                            @Identifier, 
                            @Height, 
                            @Width, 
                            @Depth, 
                            @MaxCapacity, 
                            @Type, 
                            @LevelId, 
                            @Empty,
                            @Reserved,
                            @Active,
                            @DateReserved
                        )"
            ;

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var sql = @"DELETE FROM ""Positions"" WHERE ""Id"" = @Id";
            var result = await _connection.ExecuteAsync(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<IReadOnlyList<Position>> GetAllAsync()
        {
            var sql = @"SELECT * FROM ""Positions""";
            var result = await _connection.QueryAsync<Position>(sql);
            return result.ToList();
        }

        public async Task<Position> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM ""Positions"" WHERE ""Id"" = @Id";
            var result = await _connection.QuerySingleOrDefaultAsync<Position>(sql, new { Id = id }, _transaction);
            return result;
        }

        public async Task<int> UpdateAsync(Position entity)
        {
            entity.LastModified = DateTime.Now;

            var sql = @"UPDATE ""Positions"" 
                     SET 
                        ""LastModified"" = @LastModified, 
                        ""ModifiedBy"" = @ModifiedBy, 
                        ""Identifier"" = @Identifier, 
                        ""Height"" = @Height, 
                        ""Width"" = @Width, 
                        ""Depth"" = @Depth, 
                        ""MaxCapacity"" = @MaxCapacity, 
                        ""Type"" = @Type, 
                        ""LevelId"" = @LevelId, 
                        ""Empty"" = @Empty, 
                        ""Reserved"" = @Reserved, 
                        ""Active"" = @Active, 
                        ""DateReserved"" = @DateReserved 
                     WHERE ""Id"" = @Id";

            var result = await _connection.ExecuteAsync(sql, entity, _transaction);
            return result;
        }
    }
}
