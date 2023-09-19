using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.AisleSeeder
{
    internal class AisleSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var aisleRepository = new AisleRepository(connection, transaction);

            var AISLE_01 = new Aisle
            {
                Id = StringConstans.AISLE_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                WarehouseId = StringConstans.MAIN_WAREHOUSE_ID,
                Identifier = "A1"
            };

            var AISLE_02 = new Aisle
            {
                Id = StringConstans.AISLE_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                WarehouseId = StringConstans.MAIN_WAREHOUSE_ID,
                Identifier = "A2"
            };

            var AISLE_03 = new Aisle
            {
                Id = StringConstans.AISLE_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                WarehouseId = StringConstans.MAIN_WAREHOUSE_ID,
                Identifier = "A3"
            };

            var AISLE_04 = new Aisle
            {
                Id = StringConstans.AISLE_04_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                WarehouseId = StringConstans.MAIN_WAREHOUSE_ID,
                Identifier = "A4"
            };

            var AISLE_05 = new Aisle
            {
                Id = StringConstans.AISLE_05_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                WarehouseId = StringConstans.MAIN_WAREHOUSE_ID,
                Identifier = "A5"
            };

            aisleRepository.AddAsync(AISLE_01).Wait();
            aisleRepository.AddAsync(AISLE_02).Wait();
            aisleRepository.AddAsync(AISLE_03).Wait();
            aisleRepository.AddAsync(AISLE_04).Wait();
            aisleRepository.AddAsync(AISLE_05).Wait();
        }
    }
}
