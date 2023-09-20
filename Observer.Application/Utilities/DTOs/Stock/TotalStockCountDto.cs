namespace Observer.Application.Utilities.DTOs.Stock
{
    public class TotalStockCountDto
    {
        public Guid? ItemId { get; set; }
        public Guid? StoreId { get; set; }
        public int? StockQuantity { get; set; }
        public int? MinAllowedStockQuantity { get; set; }
    }
}
