using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.BaySeeder
{
    internal class BaySeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var bayRepository = new BayRepository(connection, transaction);

            var BAY_01_01 = new Bay
            {
                Id = StringConstans.BAY_01_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_01_ID,
                Identifier = "B1"
            };
            var BAY_01_02 = new Bay
            {
                Id = StringConstans.BAY_01_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_01_ID,
                Identifier = "B2"
            };
            var BAY_01_03 = new Bay
            {
                Id = StringConstans.BAY_01_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_01_ID,
                Identifier = "B3"
            };
            var BAY_01_04 = new Bay
            {
                Id = StringConstans.BAY_01_04_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_01_ID,
                Identifier = "B4"
            };
            var BAY_02_01 = new Bay
            {
                Id = StringConstans.BAY_02_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_02_ID,
                Identifier = "B1"
            };
            var BAY_02_02 = new Bay
            {
                Id = StringConstans.BAY_02_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_02_ID,
                Identifier = "B2"
            };
            var BAY_02_03 = new Bay
            {
                Id = StringConstans.BAY_02_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_02_ID,
                Identifier = "B3"
            };
            var BAY_02_04 = new Bay
            {
                Id = StringConstans.BAY_02_04_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_02_ID,
                Identifier = "B4"
            };
            var BAY_03_01 = new Bay
            {   
                Id = StringConstans.BAY_03_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_03_ID,
                Identifier = "B1"
            };
            var BAY_03_02 = new Bay
            {
                Id = StringConstans.BAY_03_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_03_ID,
                Identifier = "B2"
            };
            var BAY_03_03 = new Bay
            {
                Id = StringConstans.BAY_03_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_03_ID,
                Identifier = "B3"
            };
            var BAY_03_04 = new Bay
            {
                Id = StringConstans.BAY_03_04_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_03_ID,
                Identifier = "B4"
            };
            var BAY_04_01 = new Bay
            {
                Id = StringConstans.BAY_04_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_04_ID,
                Identifier = "B1"
            };
            var BAY_04_02 = new Bay
            {
                Id = StringConstans.BAY_04_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_04_ID,
                Identifier = "B2"
            };
            var BAY_04_03 = new Bay
            {
                Id = StringConstans.BAY_04_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_04_ID,
                Identifier = "B3"
            };
            var BAY_04_04 = new Bay
            {
                Id = StringConstans.BAY_04_04_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_04_ID,
                Identifier = "B4"
            };
            var BAY_05_01 = new Bay
            {
                Id = StringConstans.BAY_05_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_05_ID,
                Identifier = "B1"
            };
            var BAY_05_02 = new Bay
            {
                Id = StringConstans.BAY_05_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_05_ID,
                Identifier = "B2"
            };
            var BAY_05_03 = new Bay
            {
                Id = StringConstans.BAY_05_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_05_ID,
                Identifier = "B3"
            };
            var BAY_05_04 = new Bay
            {
                Id = StringConstans.BAY_05_04_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                AisleId = StringConstans.AISLE_05_ID,
                Identifier = "B4"
            };

            bayRepository.AddAsync(BAY_01_01).Wait();
            bayRepository.AddAsync(BAY_01_02).Wait();
            bayRepository.AddAsync(BAY_01_03).Wait();
            bayRepository.AddAsync(BAY_01_04).Wait();
            bayRepository.AddAsync(BAY_02_01).Wait();
            bayRepository.AddAsync(BAY_02_02).Wait();
            bayRepository.AddAsync(BAY_02_03).Wait();
            bayRepository.AddAsync(BAY_02_04).Wait();
            bayRepository.AddAsync(BAY_03_01).Wait();
            bayRepository.AddAsync(BAY_03_02).Wait();
            bayRepository.AddAsync(BAY_03_03).Wait();
            bayRepository.AddAsync(BAY_03_04).Wait();
            bayRepository.AddAsync(BAY_04_01).Wait();
            bayRepository.AddAsync(BAY_04_02).Wait();
            bayRepository.AddAsync(BAY_04_03).Wait();
            bayRepository.AddAsync(BAY_04_04).Wait();
            bayRepository.AddAsync(BAY_05_01).Wait();
            bayRepository.AddAsync(BAY_05_02).Wait();
            bayRepository.AddAsync(BAY_05_03).Wait();
            bayRepository.AddAsync(BAY_05_04).Wait();
        }
    }
}
