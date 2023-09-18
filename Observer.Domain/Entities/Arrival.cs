﻿namespace Observer.Domain.Entities
{
    public class Arrival : Entity
    {
        public Arrival()
        {
            StockArrivals = new HashSet<StockArrival>();
        }

        public string Type { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? ItemId { get; set; }
        public int? BoxQuantity { get; set; }
        public int? ItemsPerBox { get; set; }
        public int? PalletQuantity { get; set; }
        public ICollection<StockArrival> StockArrivals { get; set; }
    }
}
