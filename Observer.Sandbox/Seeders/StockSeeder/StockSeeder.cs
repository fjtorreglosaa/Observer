using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.StockSeeder
{
    internal class StockSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var stockRepository = new StockRepository(connection, transaction);

            #region STOCKS
            var CHAIN_STOCK = new Stock
            {
                Id = StringConstans.CHAIN_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "CHAIN #40 HIGH PERFORMANCE",
                ItemId = new Guid("8380E6A5-C0F9-4B0C-8A8E-7AB89FBADCA9")
            };
            var ADHESIVES_STOCK = new Stock
            {
                Id = StringConstans.ADHESIVES_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "BOX OF ADHESIVES x5",
                ItemId = new Guid("869FE37A-ADA5-46AD-B95D-70E09787B420")
            };
            var SAW_STOCK = new Stock
            {
                Id = StringConstans.SAW_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "ELECTRICAL SAW DEWALT",
                ItemId = new Guid("F3DAB57D-A34B-4705-9700-74FF427DD0FB")
            };
            var WRENCH_STOCK = new Stock
            {
                Id = StringConstans.WRENCH_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "WRENCH 1/8",
                ItemId = new Guid("8F351BD4-D8CA-4E39-82B2-2E0318A0587B")
            };
            var TAP_STOCK = new Stock
            {
                Id = StringConstans.TAP_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "INSULATING  TAP",
                ItemId = new Guid("540E1B0C-FA93-4332-BE51-EDB32D4B6ECC")
            };
            var BELT_STOCK = new Stock
            {
                Id = StringConstans.BELT_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "SHARPENING SAW STRAP",
                ItemId = new Guid("FEFD75DC-750B-4753-956D-1D4CBFFB4CE8")
            };
            var BATTERIES_STOCK = new Stock
            {
                Id = StringConstans.BATTERIES_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "REGULAR BATTERY AA x2",
                ItemId = new Guid("C187C4F2-91E5-4B0E-A39F-EAACE686B82D")
            };
            var HAMMER_STOCK = new Stock
            {
                Id = StringConstans.HAMMER_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "STEEL HAMMER",
                ItemId = new Guid("86C42729-0601-4790-90D1-5B1F4B9723DE")
            };
            var AXE_STOCK = new Stock
            {
                Id = StringConstans.AXE_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "STEEL AXE",
                ItemId = new Guid("AB73086E-23D2-4169-9277-E02C31C5071D")
        };
            var PIPE_STOCK = new Stock
            {
                Id = StringConstans.PIPE_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "PIPE 2 INCHES NORMALIZED INDUSTRIAL S",
                ItemId = new Guid("4BAD732C-A893-479F-B94E-8EE2E92C75A4")
            };
            var CEMENT_STOCK = new Stock
            {
                Id = StringConstans.CEMENT_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "BUILDING CEMENT 50",
                ItemId = new Guid("E3487B57-A6FA-4025-8089-2E517F2966CF")
            };
            var PLASTER_STOCK = new Stock
            {
                Id = StringConstans.PLASTER_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "BUILDING PLASTER",
                ItemId = new Guid("23EFBE5B-85F8-4B72-8759-91C422F7DF6D")
            };
            var CONCRETE_STOCK = new Stock
            {
                Id = StringConstans.CONCRETE_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "BUILDING CONCRETE FAST ACTION 50",
                ItemId = new Guid("20DF1DC4-23F6-4F66-8D3F-121BE73B1512")
            };
            var DRILL_STOCK = new Stock
            {
                Id = StringConstans.DRILL_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "ELECTRICAL DRILL DEWALT",
                ItemId = new Guid("1BA6D682-5EC9-43AB-A3CE-091F6B1B3B5B")
            };
            var PAINT_STOCK = new Stock
            {
                Id = StringConstans.PAINT_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "WHITE PAINT WATER BASE 1/4",
                ItemId = new Guid("51A6F835-CA47-447B-9439-4151B9305894")
            };
            var LADDER_STOCK = new Stock
            {
                Id = StringConstans.LADDER_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "WOOD LADDER",
                ItemId = new Guid("2BAAF25F-FA3E-474F-8448-418215797114")
            };
            var PALLET_STOCK = new Stock
            {
                Id = StringConstans.PALLET_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "WOOD PALLET",
                ItemId = new Guid("BE5DD507-3B1D-4079-B513-BAAAB5D795A4")
            };
            var GRINDER_STOCK = new Stock
            {
                Id = StringConstans.GRINDER_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "ELECTRICAL GRINDER DEWALT",
                ItemId = new Guid("D95A87FD-EF9C-41BF-B6E5-DA2C6D2C7D5D")
            };
            var PADLOCK_STOCK = new Stock
            {
                Id = StringConstans.PADLOCK_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "REGULAR PADLOCK",
                ItemId = new Guid("B97DCE86-2974-439C-BA7B-4A37B653A368")
            };  
            var TOOLBOX_STOCK = new Stock
            {
                Id = StringConstans.TOOLBOX_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "REGULAR TOOLBOX",
                ItemId = new Guid("C169B1EF-958E-4470-8D6F-26EDE6C0FD9E")
            };
            var LIGHTER_STOCK = new Stock
            {
                Id = StringConstans.LIGHTER_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "REGULAR LIGHTER",
                ItemId = new Guid("4A1C3021-9B22-4140-89C0-24435AB950A8")
            };
            var NAILS_STOCK = new Stock
            {
                Id = StringConstans.NAILS_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "NAIL BOX x100",
                ItemId = new Guid("B8AC3C9F-DA9A-481F-BDDF-021B61611D38")
            };
            var HINGES_STOCK = new Stock
            {
                Id = StringConstans.HINGES_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "DOOR HINGES STAINLESS STEEL",
                ItemId = new Guid("3C7A417D-B948-4501-BED2-87F43ABC228D")
            };
            var WIRES_STOCK = new Stock
            {
                Id = StringConstans.WIRES_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "REGULAR WIRE EXTENSION",
                ItemId = new Guid("9E1F9819-CB69-4DC0-B260-46DD1FE283EC")
            };
            var GLUE_STOCK = new Stock
            {
                Id = StringConstans.GLUE_STOCK,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StoreId = StringConstans.MAIN_STORE_ID,
                Name = "WOOD GLUE",
                ItemId = new Guid("E3839AE4-B822-4F94-96B8-FF9670D60678")
            };
            #endregion

            stockRepository.AddAsync(CHAIN_STOCK).Wait();
            stockRepository.AddAsync(ADHESIVES_STOCK).Wait();
            stockRepository.AddAsync(SAW_STOCK).Wait();
            stockRepository.AddAsync(WRENCH_STOCK).Wait();
            stockRepository.AddAsync(TAP_STOCK).Wait();
            stockRepository.AddAsync(BELT_STOCK).Wait();
            stockRepository.AddAsync(BATTERIES_STOCK).Wait();
            stockRepository.AddAsync(HAMMER_STOCK).Wait();
            stockRepository.AddAsync(AXE_STOCK).Wait();
            stockRepository.AddAsync(PIPE_STOCK).Wait();
            stockRepository.AddAsync(CEMENT_STOCK).Wait();
            stockRepository.AddAsync(PLASTER_STOCK).Wait();
            stockRepository.AddAsync(CONCRETE_STOCK).Wait();
            stockRepository.AddAsync(DRILL_STOCK).Wait();
            stockRepository.AddAsync(PAINT_STOCK).Wait();
            stockRepository.AddAsync(LADDER_STOCK).Wait();
            stockRepository.AddAsync(PALLET_STOCK).Wait();
            stockRepository.AddAsync(GRINDER_STOCK).Wait();
            stockRepository.AddAsync(PADLOCK_STOCK).Wait();
            stockRepository.AddAsync(TOOLBOX_STOCK).Wait();
            stockRepository.AddAsync(LIGHTER_STOCK).Wait();
            stockRepository.AddAsync(NAILS_STOCK).Wait();
            stockRepository.AddAsync(HINGES_STOCK).Wait();
            stockRepository.AddAsync(WIRES_STOCK).Wait();
            stockRepository.AddAsync(GLUE_STOCK).Wait();
        }
    }
}
