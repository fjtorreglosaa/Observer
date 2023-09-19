using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.ArrivalSeeder
{
    internal class ArrivalSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var arrivalRepository = new ArrivalRepository(connection, transaction);

            #region ARRIVALS
            var ARRIVAL_PRODUCTS_STD_01 = new Arrival
            {
                Id = StringConstans.ARRIVAL_PRODUCTS_01,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                SupplierId = StringConstans.SUPPLIER_01,
                Type = "STANDARD"
            };
            var ARRIVAL_PRODUCTS_WAR_01 = new Arrival
            {
                Id = StringConstans.ARRIVAL_PRODUCTS_02,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                SupplierId = StringConstans.SUPPLIER_02,
                Type = "WARRANTY"
            };
            var ARRIVAL_PRODUCTS_STF_01 = new Arrival
            {
                Id = StringConstans.ARRIVAL_PRODUCTS_03,
                CreatedDate = DateTime.Now, 
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                SupplierId = StringConstans.SUPPLIER_03,
                Type = "STOCK TRANSFER"
            };
            var ARRIVAL_PRODUCTS_STD_02 = new Arrival
            {
                Id = StringConstans.ARRIVAL_PRODUCTS_04,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                SupplierId = StringConstans.SUPPLIER_04,
                Type = "STANDARD"
            };
            var ARRIVAL_PRODUCTS_STD_03 = new Arrival
            {
                Id = StringConstans.ARRIVAL_PRODUCTS_05,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                SupplierId = StringConstans.SUPPLIER_05,
                Type = "STANDARD"
            };
            #endregion

            arrivalRepository.AddAsync(ARRIVAL_PRODUCTS_STD_01).Wait();
            arrivalRepository.AddAsync(ARRIVAL_PRODUCTS_WAR_01).Wait();
            arrivalRepository.AddAsync(ARRIVAL_PRODUCTS_STF_01).Wait();
            arrivalRepository.AddAsync(ARRIVAL_PRODUCTS_STD_02).Wait();
            arrivalRepository.AddAsync(ARRIVAL_PRODUCTS_STD_03).Wait();
        }
    }
}
