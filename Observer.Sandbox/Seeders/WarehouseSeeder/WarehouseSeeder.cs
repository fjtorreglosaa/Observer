using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.WarehouseSeeder
{
    internal class WarehouseSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var warehouseRepository = new WarehouseRepository(connection, transaction);
            var warehouseName = "Main Warehouse";
            var description = "The main warehouse of the hardware store";
            var Identifier = "MWH";

            var warehouse = new Warehouse
            {
                Id = StringConstans.MAIN_WAREHOUSE_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = warehouseName,
                Description = description,
                Identifier = Identifier
            };

            warehouseRepository.AddAsync(warehouse).Wait();
        }
    }
}
