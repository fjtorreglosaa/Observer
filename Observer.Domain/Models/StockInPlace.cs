namespace Observer.Domain.Models
{
    public class StockInPlace
    {
        public Guid? ItemId { get; set; }
        public Guid? StockId { get; set; }
        public Guid? PositionId { get; set; }
        public string? Identifier { get; set; }
        public DateTime? LastDiscounted { get; set; }

    }
}
