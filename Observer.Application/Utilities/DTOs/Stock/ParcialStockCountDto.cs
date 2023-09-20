namespace Observer.Application.Utilities.DTOs.Stock
{
    public class ParcialStockCountDto
    {
        public Guid? ItemId { get; set; }
        public Guid? StockId { get; set; }
        public int? StockQuantity { get; set; }
        public int? MinimumAllowedQuantity { get; set; }
    }
}
