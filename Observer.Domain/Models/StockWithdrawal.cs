namespace Observer.Domain.Models
{
    public class StockWithdrawal : Entity
    {
        public Guid? StockId { get; set; }
        public Stock? Stock { get; set; }
        public string? Reason { get; set; }
    }
}
