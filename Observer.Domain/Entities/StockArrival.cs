namespace Observer.Domain.Entities
{
    public class StockArrival : Entity
    {
        public Guid? StockId { get; set; }
        public Stock? Stock { get; set; }
        public Guid? ArrivalId { get; set; }
        public Arrival? Arrival { get; set; }
        public Guid? ItemId { get; set; }
        public int? BoxQuantity { get; set; }
        public int? ItemsPerBox { get; set; }
        public int? PalletQuantity { get; set; }
    }
}
