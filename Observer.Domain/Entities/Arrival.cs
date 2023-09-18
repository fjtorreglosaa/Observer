namespace Observer.Domain.Entities
{
    public class Arrival : Entity
    {
        public Arrival()
        {
            StockArrivals = new HashSet<StockArrival>();
        }

        public string Type { get; set; }
        public Guid? CompanyId { get; set; }
        public ICollection<StockArrival> StockArrivals { get; set; }
    }
}
