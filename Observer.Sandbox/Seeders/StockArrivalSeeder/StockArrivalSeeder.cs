using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.StockArrivalSeeder
{
    internal class StockArrivalSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var stockArrivalRepository = new StockArrivalRepository(connection, transaction);

            Guid CHAIN = new Guid("8380E6A5-C0F9-4B0C-8A8E-7AB89FBADCA9");
            Guid ADHESIVES = new Guid("869FE37A-ADA5-46AD-B95D-70E09787B420");
            Guid WRENCH = new Guid("8F351BD4-D8CA-4E39-82B2-2E0318A0587B");
            Guid TAP = new Guid("540E1B0C-FA93-4332-BE51-EDB32D4B6ECC");
            Guid BELT = new Guid("FEFD75DC-750B-4753-956D-1D4CBFFB4CE8");
            Guid BATTERIES = new Guid("C187C4F2-91E5-4B0E-A39F-EAACE686B82D");
            Guid HAMMER = new Guid("86C42729-0601-4790-90D1-5B1F4B9723DE");
            Guid AXE = new Guid("AB73086E-23D2-4169-9277-E02C31C5071D");
            Guid PIPE = new Guid("4BAD732C-A893-479F-B94E-8EE2E92C75A4");
            Guid CEMENT = new Guid("E3487B57-A6FA-4025-8089-2E517F2966CF");
            Guid PLASTER = new Guid("23EFBE5B-85F8-4B72-8759-91C422F7DF6D");
            Guid CONCRETE = new Guid("20DF1DC4-23F6-4F66-8D3F-121BE73B1512");
            Guid DRILL = new Guid("1BA6D682-5EC9-43AB-A3CE-091F6B1B3B5B");
            Guid PAINT = new Guid("51A6F835-CA47-447B-9439-4151B9305894");
            Guid LADDER = new Guid("2BAAF25F-FA3E-474F-8448-418215797114");
            Guid PALLET = new Guid("BE5DD507-3B1D-4079-B513-BAAAB5D795A4");
            Guid GRINDER = new Guid("D95A87FD-EF9C-41BF-B6E5-DA2C6D2C7D5D");
            Guid PADLOCK = new Guid("B97DCE86-2974-439C-BA7B-4A37B653A368");
            Guid TOOLBOX = new Guid("C169B1EF-958E-4470-8D6F-26EDE6C0FD9E");
            Guid LIGHTER = new Guid("4A1C3021-9B22-4140-89C0-24435AB950A8");
            Guid NAILS = new Guid("B8AC3C9F-DA9A-481F-BDDF-021B61611D38");
            Guid HINGES = new Guid("3C7A417D-B948-4501-BED2-87F43ABC228D");
            Guid WIRES = new Guid("9E1F9819-CB69-4DC0-B260-46DD1FE283EC");
            Guid GLUE = new Guid("E3839AE4-B822-4F94-96B8-FF9670D60678");
            Guid SAW = new Guid("F3DAB57D-A34B-4705-9700-74FF427DD0FB");

            var CHAIN_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.CHAIN_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 80,
                ItemsPerBox = 10,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_01,
                StockId = StringConstans.CHAIN_STOCK,
                ItemId = CHAIN
            };
            var CHAIN_STOCK_ARRIVAL_02 = new StockArrival
            {
                Id = StringConstans.CHAIN_STOCK_ARRIVAL_02,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 25,
                ItemsPerBox = 10,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_05,
                StockId = StringConstans.CHAIN_STOCK_02,
                ItemId = CHAIN
            };
            var ADHESIVES_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.ADHESIVES_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 8,
                ItemsPerBox = 14,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.ADHESIVES_STOCK,
                ItemId = ADHESIVES
            };  
            var SAW_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.SAW_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 8,
                ItemsPerBox = 14,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.SAW_STOCK,
                ItemId = SAW
            };
            var WRENCH_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.WRENCH_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 25,
                ItemsPerBox = 16,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_01,
                StockId = StringConstans.WRENCH_STOCK,
                ItemId = WRENCH
            };
            var TAP_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.TAP_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 50,
                ItemsPerBox = 25,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_01,
                StockId = StringConstans.TAP_STOCK,
                ItemId = TAP
            };
            var BELT_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.BELT_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 100,
                ItemsPerBox = 5,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_01,
                StockId = StringConstans.BELT_STOCK,
                ItemId = BELT
            };
            var BATTERIES_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.BATTERIES_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 10,
                ItemsPerBox = 20,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_01,
                StockId = StringConstans.BATTERIES_STOCK,
                ItemId = BATTERIES
            };
            var HAMMER_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.HAMMER_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 2,
                ItemsPerBox = 10,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_02,
                StockId = StringConstans.HAMMER_STOCK,
                ItemId = HAMMER
            };
            var AXE_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.AXE_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 1,
                ItemsPerBox = 5,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_02,
                StockId = StringConstans.AXE_STOCK,
                ItemId = AXE
            };
            var PIPE_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.PIPE_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 4,
                ItemsPerBox = 10,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_02,
                StockId = StringConstans.PIPE_STOCK,
                ItemId = PIPE
            };
            var CEMENT_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.CEMENT_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 8,
                ItemsPerBox = 2,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_02,
                StockId = StringConstans.CEMENT_STOCK,
                ItemId = CEMENT
            };
            var PLASTER_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.PLASTER_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 2,
                ItemsPerBox = 2,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_02,
                StockId = StringConstans.PLASTER_STOCK,
                ItemId = PLASTER
            };
            var CONCRETE_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.CONCRETE_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 10,
                ItemsPerBox = 1,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_03,
                StockId = StringConstans.CONCRETE_STOCK,
                ItemId = CONCRETE
            };
            var DRILL_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.DRILL_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 10,
                ItemsPerBox = 8,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_03,
                StockId = StringConstans.DRILL_STOCK,
                ItemId = DRILL
            };
            var PAINT_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.PAINT_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 15,
                ItemsPerBox = 25,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_03,
                StockId = StringConstans.PAINT_STOCK,
                ItemId = PAINT
            };
            var LADDER_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.LADDER_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 12,
                ItemsPerBox = 1,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.LADDER_STOCK,
                ItemId = LADDER
            };
            var PALLET_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.PALLET_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 12,
                ItemsPerBox = 4,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.PALLET_STOCK,
                ItemId = PALLET
            };
            var GRINDER_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.GRINDER_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 10,
                ItemsPerBox = 6,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.GRINDER_STOCK,
                ItemId = GRINDER
            };
            var PADLOCK_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.PADLOCK_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 25,
                ItemsPerBox = 10,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.PADLOCK_STOCK,
                ItemId = PADLOCK
            };
            var TOOLBOX_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.TOOLBOX_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 10,
                ItemsPerBox = 1,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.TOOLBOX_STOCK,
                ItemId = TOOLBOX
            };
            var LIGHTER_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.LIGHTER_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 15,
                ItemsPerBox = 2,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.LIGHTER_STOCK,
                ItemId = LIGHTER
            };
            var NAILS_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.NAILS_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 50,
                ItemsPerBox = 100,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.NAILS_STOCK,
                ItemId = NAILS
            };
            var HINGES_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.HINGES_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 16,
                ItemsPerBox = 8,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.HINGES_STOCK,
                ItemId = HINGES
            };
            var WIRES_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.WIRES_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 35,
                ItemsPerBox = 10,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.WIRES_STOCK,
                ItemId = WIRES
            };
            var GLUE_STOCK_ARRIVAL = new StockArrival
            {
                Id = StringConstans.GLUE_STOCK_ARRIVAL,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BoxQuantity = 20,
                ItemsPerBox = 5,
                IsPalletArrival = false,
                ArrivalId = StringConstans.ARRIVAL_PRODUCTS_04,
                StockId = StringConstans.GLUE_STOCK,
                ItemId = GLUE
            };

            stockArrivalRepository.AddAsync(CHAIN_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(ADHESIVES_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(SAW_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(WRENCH_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(TAP_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(BELT_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(BATTERIES_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(HAMMER_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(AXE_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(PIPE_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(CEMENT_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(PLASTER_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(CONCRETE_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(DRILL_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(PAINT_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(LADDER_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(PALLET_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(GRINDER_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(PADLOCK_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(TOOLBOX_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(LIGHTER_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(NAILS_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(HINGES_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(WIRES_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(GLUE_STOCK_ARRIVAL).Wait();
            stockArrivalRepository.AddAsync(CHAIN_STOCK_ARRIVAL_02).Wait();
        }
    }
}
