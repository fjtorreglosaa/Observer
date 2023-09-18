namespace Observer.Domain.Entities
{
    public class StockAlert : Entity
    {
        public Guid? StockId { get; set; }
        public Stock? Stock { get; set; }
        public Guid? AlertId { get; set; }
        public Alert? Alert { get; set; }
    }
}
