namespace Observer.Domain.Models
{
    public class Alert : Entity
    {
        public Alert()
        {
            StockAlerts = new HashSet<StockAlert>();
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public ICollection<StockAlert> StockAlerts { get; set; }
    }
}
