using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.AlertSeeder
{
    internal class AlertSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var alertRepository = new AlertRepository(connection, transaction);

            var PARTIAL_STOCK_ALERT = new Alert
            {
                Id = Guid.Parse("2c39738d-1020-4148-82e6-e80ce9760053"),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = "LOW STOCK",
                Description = "Stock alert when the quantity of units is less than the minimum quantity of a product for a particular shelf/pallet.",
                Type = "GENERIC"
            };

            var TOTAL_STOCK_ALERT = new Alert
            {
                Id = Guid.Parse("9b6a9b83-7e22-4a4b-9e9f-633219c0c661"),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = "LOW STOCK",
                Description = "Stock alert when the quantity of units is less than the minimum quantity for a product in the total stock.",
                Type = "GENERIC"
            };

            var STOCK_ROTATION_ALERT = new Alert
            {
                Id = Guid.Parse("d4cfd857-e4ac-4f0a-92ec-9845abb7c650"),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = "LOW ROTATION",
                Description = "Stock alert when an item has not been discounted for more than 15 days",
                Type = "AUTO"
            };

            var STOCK_ARRIVAL_ALERT = new Alert
            {
                Id = Guid.Parse("9a6de3c6-8c85-4eab-931d-189c66e42ac5"),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = "LOW STOCK",
                Description = "Stock alert when a warehouse receives products from a supplier",
                Type = "GENERIC"
            };

            alertRepository.AddAsync(PARTIAL_STOCK_ALERT).Wait();
            alertRepository.AddAsync(TOTAL_STOCK_ALERT).Wait();
            alertRepository.AddAsync(STOCK_ROTATION_ALERT).Wait();
            alertRepository.AddAsync(STOCK_ARRIVAL_ALERT).Wait();
        }
    }
}
