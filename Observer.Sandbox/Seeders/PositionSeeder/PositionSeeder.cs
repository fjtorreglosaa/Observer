using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.PositionSeeder
{
    internal class PositionSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var positionRepository = new PositionRepository(connection, transaction);
            var levelRepository = new LevelRepository(connection, transaction);
            var positionsPerLevel = 3;
            var levels = levelRepository.GetAllAsync().Result;
            int positionId = 1;

            if (levels.Any())
            {
                foreach (var level in levels)
                {
                    for (int i = 1; i <= positionsPerLevel; i++)
                    {
                        var position = new Position
                        {
                            Id = Converter.ToGuid(positionId),
                            CreatedDate = DateTime.Now,
                            LastModified = DateTime.Now,
                            CreatedBy = StringConstans.MAIN_USER_ID,
                            ModifiedBy = StringConstans.MAIN_USER_ID,
                            Active = true,
                            Empty = true,
                            Reserved = false,
                            Height = 60,
                            Depth = 80,
                            Width = 50,
                            MaxCapacity = 10,
                            LevelId = level.Id,
                            Type = "SHELF",
                            DateReserved = null,
                            Identifier = $"P{i}"
                        };

                        positionId++;

                        positionRepository.AddAsync(position).Wait();
                    }
                }
            }

        }
    }
}
