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

            var LOW_STOCK_ALERT = new Alert
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = "LOW STOCK",
                Description = "Stock alert when there are at least 10 units of a product left in stock",
                Type = "DAILY"
            };

            var STOCK_ROTATION_ALERT = new Alert
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = "LOW ROTATION",
                Description = "Stock alert when an item has not been discounted for more than 15 days",
                Type = "WEEKLY"
            };

            var STOCK_ARRIVAL_ALERT = new Alert
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                Name = "LOW STOCK",
                Description = "Stock alert when a warehouse receives products from a supplier",
                Type = "AUTO"
            };

            alertRepository.AddAsync(LOW_STOCK_ALERT).Wait();
            alertRepository.AddAsync(STOCK_ROTATION_ALERT).Wait();
            alertRepository.AddAsync(STOCK_ARRIVAL_ALERT).Wait();
        }
    }
}
