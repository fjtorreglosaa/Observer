namespace Observer.Domain.Entities
{
    public class Stock : Entity
    {
        public Stock()
        {
            StockAlerts = new HashSet<StockAlert>();
            StockArrivals = new HashSet<StockArrival>();
            StockWithdrawals = new HashSet<StockWithdrawal>();
        }

        public Guid? CompanyId { get; set; }
        public Guid? ItemId { get; set; }
        public Guid? PositionId { get; set; }
        public Position Position { get; set; }
        public int? Quantity { get; set; }
        public DateTime? LastDiscounted { get; set; }
        public int? TimesDiscounted { get; set; }
        public decimal? DiscountedItemsPerUpdateAvg { get; set; }
        public ICollection<StockArrival> StockArrivals { get; set; }
        public ICollection<StockWithdrawal> StockWithdrawals { get; set; }
        public ICollection<StockAlert> StockAlerts { get; set; }
    }
}
