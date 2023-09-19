using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.StockPositionSeeder
{
    internal class StockPositionSeeder
    {
        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var stockPositionRepository = new StockPositionRepository(connection, transaction);

            var CHAIN_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.CHAIN_STOCK,
                PositionId = Converter.ToGuid(1)
            };
            var ADHESIVES_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.ADHESIVES_STOCK,
                PositionId = Converter.ToGuid(2)
            };
            var WRENCH_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.WRENCH_STOCK,
                PositionId = Converter.ToGuid(3)
            };
            var TAP_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.TAP_STOCK,
                PositionId = Converter.ToGuid(4)
            };
            var BELT_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.BELT_STOCK,
                PositionId = Converter.ToGuid(5)
            };
            var BATTERIES_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.BATTERIES_STOCK,
                PositionId = Converter.ToGuid(6)
            };
            var HAMMER_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.HAMMER_STOCK,
                PositionId = Converter.ToGuid(7)
            };
            var AXE_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.AXE_STOCK,
                PositionId = Converter.ToGuid(8)
            };
            var PIPE_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.PIPE_STOCK,
                PositionId = Converter.ToGuid(9)
            };
            var CEMENT_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.CEMENT_STOCK,
                PositionId = Converter.ToGuid(10)
            };
            var PLASTER_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.PLASTER_STOCK,
                PositionId = Converter.ToGuid(11)
            };
            var CONCRETE_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.CONCRETE_STOCK,
                PositionId = Converter.ToGuid(12)
            };
            var DRILL_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.DRILL_STOCK,
                PositionId = Converter.ToGuid(13)
            };
            var PAINT_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.PAINT_STOCK,
                PositionId = Converter.ToGuid(14)
            };
            var LADDER_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.LADDER_STOCK,
                PositionId = Converter.ToGuid(15)
            };
            var PALLET_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.PALLET_STOCK,
                PositionId = Converter.ToGuid(16)
            };
            var GRINDER_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.GRINDER_STOCK,
                PositionId = Converter.ToGuid(17)
            };
            var PADLOCK_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.PADLOCK_STOCK,
                PositionId = Converter.ToGuid(18)
            };
            var TOOLBOX_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.TOOLBOX_STOCK,
                PositionId = Converter.ToGuid(19)
            };
            var LIGHTER_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.LIGHTER_STOCK,
                PositionId = Converter.ToGuid(20)
            };
            var NAILS_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.NAILS_STOCK,
                PositionId = Converter.ToGuid(21)
            };
            var HINGES_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.HINGES_STOCK,
                PositionId = Converter.ToGuid(22)
            };
            var WIRES_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.WIRES_STOCK,
                PositionId = Converter.ToGuid(23)
            };
            var GLUE_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.GLUE_STOCK,
                PositionId = Converter.ToGuid(24)
            };
            var SAW_STOCK_POSITION = new StockPosition
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                StockId = StringConstans.SAW_STOCK,
                PositionId = Converter.ToGuid(25)
            };

            stockPositionRepository.AddAsync(CHAIN_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(ADHESIVES_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(WRENCH_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(TAP_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(BELT_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(BATTERIES_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(HAMMER_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(AXE_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(PIPE_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(CEMENT_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(PLASTER_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(CONCRETE_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(DRILL_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(PAINT_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(LADDER_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(PALLET_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(GRINDER_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(PADLOCK_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(TOOLBOX_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(LIGHTER_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(NAILS_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(HINGES_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(WIRES_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(GLUE_STOCK_POSITION).Wait();
            stockPositionRepository.AddAsync(SAW_STOCK_POSITION).Wait();
        }
    }
}
