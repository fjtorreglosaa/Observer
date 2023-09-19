using Npgsql;
using Observer.Sandbox.Seeders.AisleSeeder;
using Observer.Sandbox.Seeders.AlertSeeder;
using Observer.Sandbox.Seeders.ArrivalSeeder;
using Observer.Sandbox.Seeders.BaySeeder;
using Observer.Sandbox.Seeders.LevelSeeder;
using Observer.Sandbox.Seeders.PositionSeeder;
using Observer.Sandbox.Seeders.StockArrivalSeeder;
using Observer.Sandbox.Seeders.StockPositionSeeder;
using Observer.Sandbox.Seeders.StockSeeder;
using Observer.Sandbox.Seeders.WarehouseSeeder;

namespace Observer.Sandbox.Utilities
{
    internal class EnvironmentSetup
    {
        public static void Setup()
        {
            var connectionString = "Server=localhost;Database=ObserverDB;Port=5432;User Id=postgres;Password=Password1*";
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var transaction = connection.BeginTransaction();

            WarehouseSeeder.Seed(connection, transaction);
            AisleSeeder.Seed(connection, transaction);
            BaySeeder.Seed(connection, transaction);
            LevelSeeder.Seed(connection, transaction);
            PositionSeeder.Seed(connection, transaction);
            AlertSeeder.Seed(connection, transaction);
            StockSeeder.Seed(connection, transaction);
            ArrivalSeeder.Seed(connection, transaction);
            StockArrivalSeeder.Seed(connection, transaction);
            StockPositionSeeder.Seed(connection, transaction);

            transaction.Commit();
        }
    }
}
