namespace Observer.Domain.Models
{
    public class StockAlert
    {
        public Guid? StockId { get; set; }
        public Stock? Stock { get; set; }
        public Guid? AlertId { get; set; }
        public Alert? Alert { get; set; }
    }
}
