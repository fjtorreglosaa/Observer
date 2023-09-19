using Observer.Domain.Entities;
using Observer.Infrastructure.Repositories;
using Observer.Sandbox.Utilities;
using System.Data;

namespace Observer.Sandbox.Seeders.LevelSeeder
{
    internal class LevelSeeder
    {
        public static Guid LEVEL_01_01_01_ID = new Guid("E4113F3B-6041-4D50-B8D2-6D7E8AB057B8");
        public static Guid LEVEL_01_01_02_ID = new Guid("F56140F5-0816-444B-BE4A-9698303FA1ED");
        public static Guid LEVEL_01_01_03_ID = new Guid("31AD8F31-2B14-45BC-8BC0-725C044A6298");
        public static Guid LEVEL_01_02_01_ID = new Guid("018D22C9-F88B-424B-8394-C1A18F6C2CC8");
        public static Guid LEVEL_01_02_02_ID = new Guid("0409D138-CC5F-4EF9-A1EB-EDA0375CA236");
        public static Guid LEVEL_01_02_03_ID = new Guid("B2120AF1-7710-493D-9244-EFFF4487149D");
        public static Guid LEVEL_01_03_01_ID = new Guid("A484881F-FE2E-49B9-BFA8-0AAD9871C6C9");
        public static Guid LEVEL_01_03_02_ID = new Guid("239EBBE0-2527-466C-9B61-C0D3C7DA77D1");
        public static Guid LEVEL_01_03_03_ID = new Guid("A15B1311-E6C3-4E49-9396-8314E20375DE");
        public static Guid LEVEL_01_04_01_ID = new Guid("8D3ACF22-FB34-4452-9978-59469EC85F31");
        public static Guid LEVEL_01_04_02_ID = new Guid("EBB88FA8-1538-499E-B7C0-B7FF4D47387C");
        public static Guid LEVEL_01_04_03_ID = new Guid("B08A703D-8A2F-47C7-8923-895B783C088E");
        public static Guid LEVEL_02_01_01_ID = new Guid("900F6C60-DD4B-4244-B2EA-DEDCB487A07A");
        public static Guid LEVEL_02_01_02_ID = new Guid("EDBAEF26-CCCE-4A51-ACD6-3E4B11680048");
        public static Guid LEVEL_02_01_03_ID = new Guid("57E95488-EA8C-4AC2-BD58-1A407B21F348");
        public static Guid LEVEL_02_02_01_ID = new Guid("94D3BB41-5020-4FD9-AFF5-1DF765F420A8");
        public static Guid LEVEL_02_02_02_ID = new Guid("9B24EABB-B848-478C-BE60-FB58572D3660");
        public static Guid LEVEL_02_02_03_ID = new Guid("231C26A2-FE60-4060-8731-F86FEF234376");
        public static Guid LEVEL_02_03_01_ID = new Guid("3366F364-9BDE-490D-AFF6-A988C313F4B2");
        public static Guid LEVEL_02_03_02_ID = new Guid("D497D922-8B6D-4F0F-A585-E18ABE8ED01D");
        public static Guid LEVEL_02_03_03_ID = new Guid("C808DE40-B4B5-46A2-9976-03BCDCBA83F0");
        public static Guid LEVEL_02_04_01_ID = new Guid("23C71264-0F08-43DC-8366-B6187B72BD7C");
        public static Guid LEVEL_02_04_02_ID = new Guid("2493D474-9F7B-4CE6-A00A-CF43A093DF7A");
        public static Guid LEVEL_02_04_03_ID = new Guid("2D089AB8-6405-412F-83D3-75F120DB3BBF");
        public static Guid LEVEL_03_01_01_ID = new Guid("583159CA-BDE5-405E-8FB7-B0762D626816");
        public static Guid LEVEL_03_01_02_ID = new Guid("B67EEC4C-3BD6-4B6F-A79A-B0505CC9FCE4");
        public static Guid LEVEL_03_01_03_ID = new Guid("F1BD903F-626F-421B-B2FE-66FA81FF7EE1");
        public static Guid LEVEL_03_02_01_ID = new Guid("8CFEA04E-F5DD-483E-BED7-43EEE5703E9B");
        public static Guid LEVEL_03_02_02_ID = new Guid("BFE91893-5991-43FC-822B-29ED194CE214");
        public static Guid LEVEL_03_02_03_ID = new Guid("42BC5CF4-EAED-4AC9-952E-F251349AA2B9");
        public static Guid LEVEL_03_03_01_ID = new Guid("975D6F38-A183-4430-966A-FD935DE9BD68");
        public static Guid LEVEL_03_03_02_ID = new Guid("7DECAC53-D973-4FDF-92CC-D4C24A1202DF");
        public static Guid LEVEL_03_03_03_ID = new Guid("B097C673-53A0-460C-AFA1-72F28CA160A8");
        public static Guid LEVEL_03_04_01_ID = new Guid("B08BE6B2-C370-4954-ABE1-3EC01FB63E3C");
        public static Guid LEVEL_03_04_02_ID = new Guid("C908E9B1-CA9E-49E9-ABD8-4A3FE5DB298F");
        public static Guid LEVEL_03_04_03_ID = new Guid("D174C421-0C59-42ED-9F13-EE66E6B7049E");
        public static Guid LEVEL_04_01_01_ID = new Guid("2113F6B7-22F3-43A5-8D1A-395A094EBB00");
        public static Guid LEVEL_04_01_02_ID = new Guid("18230CEE-4661-4A59-B520-B631687D12DA");
        public static Guid LEVEL_04_01_03_ID = new Guid("BD4F3AC8-AB07-4E22-A9EF-0742558E1ED2");
        public static Guid LEVEL_04_02_01_ID = new Guid("C4B1D59C-C43B-4AF0-9E6B-30B1F4FDAA93");
        public static Guid LEVEL_04_02_02_ID = new Guid("00732F23-3A31-4AFB-A16F-330A65217492");
        public static Guid LEVEL_04_02_03_ID = new Guid("39D2243D-6E7D-4005-AB83-1AF3635C6E28");
        public static Guid LEVEL_04_03_01_ID = new Guid("7BB98EB9-1945-4DF1-81FE-6FECABD8E15C");
        public static Guid LEVEL_04_03_02_ID = new Guid("8F0A271D-5097-4994-B640-51E71BA0C677");
        public static Guid LEVEL_04_03_03_ID = new Guid("89B96222-D3EE-4F67-9F0B-955F92FE4DF1");
        public static Guid LEVEL_04_04_01_ID = new Guid("488575D1-DB3E-49E4-9CA3-A277275A4DB8");
        public static Guid LEVEL_04_04_02_ID = new Guid("980D97E6-7906-4DAE-809E-6188319C103B");
        public static Guid LEVEL_04_04_03_ID = new Guid("CFBB91A0-6EF5-466B-81A8-F89CDB927BAA");
        public static Guid LEVEL_05_01_01_ID = new Guid("46A5B52F-C0B8-4DBF-BA1B-FA79BD04D745");
        public static Guid LEVEL_05_01_02_ID = new Guid("5B4ECAEA-1D8B-4C10-BC71-137A0FE6780B");
        public static Guid LEVEL_05_01_03_ID = new Guid("3E0FE1CE-D6EC-42FB-8195-1E5D474F7166");
        public static Guid LEVEL_05_02_01_ID = new Guid("38A50AC8-A5C4-4A9A-B758-3265752B6F66");
        public static Guid LEVEL_05_02_02_ID = new Guid("2922DD1C-2B5E-4796-90C8-4BB8FFE4D02D");
        public static Guid LEVEL_05_02_03_ID = new Guid("0378C649-E936-4BD0-B7C8-07A58F59BDE6");
        public static Guid LEVEL_05_03_01_ID = new Guid("D79BA689-34EE-48BB-9D38-CC2480662E21");
        public static Guid LEVEL_05_03_02_ID = new Guid("AA256BAD-64C6-4A79-ACFA-589EEA358711");
        public static Guid LEVEL_05_03_03_ID = new Guid("027441AC-E296-4118-A007-689303188F0F");
        public static Guid LEVEL_05_04_01_ID = new Guid("1C21F0B0-75C6-4A5B-9D64-D5B1237A98A9");
        public static Guid LEVEL_05_04_02_ID = new Guid("03A60853-1B47-4874-85A1-6ABC760FC95B");
        public static Guid LEVEL_05_04_03_ID = new Guid("F72D0349-36D3-43B7-89BF-DB122523CFD8");

        public static void Seed(IDbConnection connection, IDbTransaction transaction)
        {
            var levelRepository = new LevelRepository(connection, transaction);

            var LEVEL_01_01_01 = new Level
            {
                Id = LEVEL_01_01_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_01_ID,
                Identifier = "L1"
            };
            var LEVEL_01_01_02 = new Level
            {
                Id = LEVEL_01_01_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_01_ID,
                Identifier = "L2"
            };
            var LEVEL_01_01_03 = new Level
            {
                Id = LEVEL_01_01_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_01_ID,
                Identifier = "L3"
            };
            var LEVEL_01_02_01 = new Level
            {
                Id = LEVEL_01_02_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_02_ID,
                Identifier = "L1"
            };
            var LEVEL_01_02_02 = new Level
            {
                Id = LEVEL_01_02_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_02_ID,
                Identifier = "L2"
            };
            var LEVEL_01_02_03 = new Level
            {
                Id = LEVEL_01_02_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_02_ID,
                Identifier = "L3"
            };
            var LEVEL_01_03_01 = new Level
            {
                Id = LEVEL_01_03_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_03_ID,
                Identifier = "L1"
            };
            var LEVEL_01_03_02 = new Level
            {
                Id = LEVEL_01_03_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_03_ID,
                Identifier = "L2"
            };
            var LEVEL_01_03_03 = new Level
            {
                Id = LEVEL_01_03_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_03_ID,
                Identifier = "L3"
            };
            var LEVEL_01_04_01 = new Level
            {
                Id = LEVEL_01_04_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_04_ID,
                Identifier = "L1"
            };
            var LEVEL_01_04_02 = new Level
            {
                Id = LEVEL_01_04_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_04_ID,
                Identifier = "L2"
            };
            var LEVEL_01_04_03 = new Level
            {
                Id = LEVEL_01_04_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_01_04_ID,
                Identifier = "L3"
            };
            var LEVEL_02_01_01 = new Level
            {
                Id = LEVEL_02_01_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_01_ID,
                Identifier = "L1"
            };
            var LEVEL_02_01_02 = new Level
            {
                Id = LEVEL_02_01_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_01_ID,
                Identifier = "L2"
            };
            var LEVEL_02_01_03 = new Level
            {
                Id = LEVEL_02_01_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_01_ID,
                Identifier = "L3"
            };
            var LEVEL_02_02_01 = new Level
            {
                Id = LEVEL_02_02_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_02_ID,
                Identifier = "L1"
            };
            var LEVEL_02_02_02 = new Level
            {
                Id = LEVEL_02_02_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_02_ID,
                Identifier = "L2"
            };
            var LEVEL_02_02_03 = new Level
            {
                Id = LEVEL_02_02_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_02_ID,
                Identifier = "L3"
            };
            var LEVEL_02_03_01 = new Level
            {
                Id = LEVEL_02_03_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_03_ID,
                Identifier = "L1"
            };
            var LEVEL_02_03_02 = new Level
            {
                Id = LEVEL_02_03_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_03_ID,
                Identifier = "L2"
            };
            var LEVEL_02_03_03 = new Level
            {
                Id = LEVEL_02_03_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_03_ID,
                Identifier = "L3"
            };
            var LEVEL_02_04_01 = new Level
            {
                Id = LEVEL_02_04_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_04_ID,
                Identifier = "L1"
            };
            var LEVEL_02_04_02 = new Level
            {
                Id = LEVEL_02_04_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_04_ID,
                Identifier = "L2"
            };
            var LEVEL_02_04_03 = new Level
            {
                Id = LEVEL_02_04_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_02_04_ID,
                Identifier = "L3"
            };
            var LEVEL_03_01_01 = new Level
            {
                Id = LEVEL_03_01_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_01_ID,
                Identifier = "L1"
            };
            var LEVEL_03_01_02 = new Level
            {
                Id = LEVEL_03_01_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_01_ID,
                Identifier = "L2"
            };
            var LEVEL_03_01_03 = new Level
            {
                Id = LEVEL_03_01_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_01_ID,
                Identifier = "L3"
            };
            var LEVEL_03_02_01 = new Level
            {
                Id = LEVEL_03_02_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_02_ID,
                Identifier = "L1"
            };
            var LEVEL_03_02_02 = new Level
            {
                Id = LEVEL_03_02_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_02_ID,
                Identifier = "L2"
            };
            var LEVEL_03_02_03 = new Level
            {
                Id = LEVEL_03_02_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_02_ID,
                Identifier = "L3"
            };
            var LEVEL_03_03_01 = new Level
            {
                Id = LEVEL_03_03_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_03_ID,
                Identifier = "L1"
            };
            var LEVEL_03_03_02 = new Level
            {
                Id = LEVEL_03_03_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_03_ID,
                Identifier = "L2"
            };
            var LEVEL_03_03_03 = new Level
            {
                Id = LEVEL_03_03_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_03_ID,
                Identifier = "L3"
            };
            var LEVEL_03_04_01 = new Level
            {
                Id = LEVEL_03_04_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_04_ID,
                Identifier = "L1"
            };
            var LEVEL_03_04_02 = new Level
            {
                Id = LEVEL_03_04_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_04_ID,
                Identifier = "L2"
            };
            var LEVEL_03_04_03 = new Level
            {
                Id = LEVEL_03_04_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_03_04_ID,
                Identifier = "L3"
            };
            var LEVEL_04_01_01 = new Level
            {
                Id = LEVEL_04_01_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_01_ID,
                Identifier = "L1"
            };
            var LEVEL_04_01_02 = new Level
            {
                Id = LEVEL_04_01_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_01_ID,
                Identifier = "L2"
            };
            var LEVEL_04_01_03 = new Level
            {
                Id = LEVEL_04_01_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_01_ID,
                Identifier = "L3"
            };
            var LEVEL_04_02_01 = new Level
            {
                Id = LEVEL_04_02_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_02_ID,
                Identifier = "L1"
            };
            var LEVEL_04_02_02 = new Level
            {
                Id = LEVEL_04_02_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_02_ID,
                Identifier = "L2"
            };
            var LEVEL_04_02_03 = new Level
            {
                Id = LEVEL_04_02_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_02_ID,
                Identifier = "L3"
            };
            var LEVEL_04_03_01 = new Level
            {
                Id = LEVEL_04_03_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_03_ID,
                Identifier = "L1"
            };
            var LEVEL_04_03_02 = new Level
            {
                Id = LEVEL_04_03_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_03_ID,
                Identifier = "L2"
            };
            var LEVEL_04_03_03 = new Level
            {
                Id = LEVEL_04_03_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_03_ID,
                Identifier = "L3"
            };
            var LEVEL_04_04_01 = new Level
            {
                Id = LEVEL_04_04_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_04_ID,
                Identifier = "L1"
            };
            var LEVEL_04_04_02 = new Level
            {
                Id = LEVEL_04_04_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_04_ID,
                Identifier = "L2"
            };
            var LEVEL_04_04_03 = new Level
            {
                Id = LEVEL_04_04_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_04_04_ID,
                Identifier = "L3"
            };
            var LEVEL_05_01_01 = new Level
            {
                Id = LEVEL_05_01_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_01_ID,
                Identifier = "L1"
            };
            var LEVEL_05_01_02 = new Level
            {
                Id = LEVEL_05_01_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_01_ID,
                Identifier = "L2"
            };
            var LEVEL_05_01_03 = new Level
            {
                Id = LEVEL_05_01_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_01_ID,
                Identifier = "L3"
            };
            var LEVEL_05_02_01 = new Level
            {
                Id = LEVEL_05_02_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_02_ID,
                Identifier = "L1"
            };
            var LEVEL_05_02_02 = new Level
            {
                Id = LEVEL_05_02_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_02_ID,
                Identifier = "L2"
            };
            var LEVEL_05_02_03 = new Level
            {
                Id = LEVEL_05_02_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_02_ID,
                Identifier = "L3"
            };
            var LEVEL_05_03_01 = new Level
            {
                Id = LEVEL_05_03_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_03_ID,
                Identifier = "L1"
            };
            var LEVEL_05_03_02 = new Level
            {
                Id = LEVEL_05_03_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_03_ID,
                Identifier = "L2"
            };
            var LEVEL_05_03_03 = new Level
            {
                Id = LEVEL_05_03_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_03_ID,
                Identifier = "L3"
            };
            var LEVEL_05_04_01 = new Level
            {
                Id = LEVEL_05_04_01_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_04_ID,
                Identifier = "L1"
            };
            var LEVEL_05_04_02 = new Level
            {
                Id = LEVEL_05_04_02_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_04_ID,
                Identifier = "L2"
            };
            var LEVEL_05_04_03 = new Level
            {
                Id = LEVEL_05_04_03_ID,
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = StringConstans.MAIN_USER_ID,
                ModifiedBy = StringConstans.MAIN_USER_ID,
                BayId = StringConstans.BAY_05_04_ID,
                Identifier = "L3"
            };

            levelRepository.AddAsync(LEVEL_01_01_01).Wait();
            levelRepository.AddAsync(LEVEL_01_01_02).Wait();
            levelRepository.AddAsync(LEVEL_01_01_03).Wait();
            levelRepository.AddAsync(LEVEL_01_02_01).Wait();
            levelRepository.AddAsync(LEVEL_01_02_02).Wait();
            levelRepository.AddAsync(LEVEL_01_02_03).Wait();
            levelRepository.AddAsync(LEVEL_01_03_01).Wait();
            levelRepository.AddAsync(LEVEL_01_03_02).Wait();
            levelRepository.AddAsync(LEVEL_01_03_03).Wait();
            levelRepository.AddAsync(LEVEL_01_04_01).Wait();
            levelRepository.AddAsync(LEVEL_01_04_02).Wait();
            levelRepository.AddAsync(LEVEL_01_04_03).Wait();
            levelRepository.AddAsync(LEVEL_02_01_01).Wait();
            levelRepository.AddAsync(LEVEL_02_01_02).Wait();
            levelRepository.AddAsync(LEVEL_02_01_03).Wait();
            levelRepository.AddAsync(LEVEL_02_02_01).Wait();
            levelRepository.AddAsync(LEVEL_02_02_02).Wait();
            levelRepository.AddAsync(LEVEL_02_02_03).Wait();
            levelRepository.AddAsync(LEVEL_02_03_01).Wait();
            levelRepository.AddAsync(LEVEL_02_03_02).Wait();
            levelRepository.AddAsync(LEVEL_02_03_03).Wait();
            levelRepository.AddAsync(LEVEL_02_04_01).Wait();
            levelRepository.AddAsync(LEVEL_02_04_02).Wait();
            levelRepository.AddAsync(LEVEL_02_04_03).Wait();
            levelRepository.AddAsync(LEVEL_03_01_01).Wait();
            levelRepository.AddAsync(LEVEL_03_01_02).Wait();
            levelRepository.AddAsync(LEVEL_03_01_03).Wait();
            levelRepository.AddAsync(LEVEL_03_02_01).Wait();
            levelRepository.AddAsync(LEVEL_03_02_02).Wait();
            levelRepository.AddAsync(LEVEL_03_02_03).Wait();
            levelRepository.AddAsync(LEVEL_03_03_01).Wait();
            levelRepository.AddAsync(LEVEL_03_03_02).Wait();
            levelRepository.AddAsync(LEVEL_03_03_03).Wait();
            levelRepository.AddAsync(LEVEL_03_04_01).Wait();
            levelRepository.AddAsync(LEVEL_03_04_02).Wait();
            levelRepository.AddAsync(LEVEL_03_04_03).Wait();
            levelRepository.AddAsync(LEVEL_04_01_01).Wait();
            levelRepository.AddAsync(LEVEL_04_01_02).Wait();
            levelRepository.AddAsync(LEVEL_04_01_03).Wait();
            levelRepository.AddAsync(LEVEL_04_02_01).Wait();
            levelRepository.AddAsync(LEVEL_04_02_02).Wait();
            levelRepository.AddAsync(LEVEL_04_02_03).Wait();
            levelRepository.AddAsync(LEVEL_04_03_01).Wait();
            levelRepository.AddAsync(LEVEL_04_03_02).Wait();
            levelRepository.AddAsync(LEVEL_04_03_03).Wait();
            levelRepository.AddAsync(LEVEL_04_04_01).Wait();
            levelRepository.AddAsync(LEVEL_04_04_02).Wait();
            levelRepository.AddAsync(LEVEL_04_04_03).Wait();
            levelRepository.AddAsync(LEVEL_05_01_01).Wait();
            levelRepository.AddAsync(LEVEL_05_01_02).Wait();
            levelRepository.AddAsync(LEVEL_05_01_03).Wait();
            levelRepository.AddAsync(LEVEL_05_02_01).Wait();
            levelRepository.AddAsync(LEVEL_05_02_02).Wait();
            levelRepository.AddAsync(LEVEL_05_02_03).Wait();
            levelRepository.AddAsync(LEVEL_05_03_01).Wait();
            levelRepository.AddAsync(LEVEL_05_03_02).Wait();
            levelRepository.AddAsync(LEVEL_05_03_03).Wait();
            levelRepository.AddAsync(LEVEL_05_04_01).Wait();
            levelRepository.AddAsync(LEVEL_05_04_02).Wait();
            levelRepository.AddAsync(LEVEL_05_04_03).Wait();
        }
    }
}
