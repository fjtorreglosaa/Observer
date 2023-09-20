namespace Observer.Application.Utilities.DTOs.Stock
{
    public class StockInPlaceDto
    {
        public Guid? ItemId { get; set; }
        public Guid? StockId { get; set; }
        public Guid? PositionId { get; set; }
        public string? Identifier { get; set; }
        public int? DaysFromLastDiscount { get; set; }
    }
}
