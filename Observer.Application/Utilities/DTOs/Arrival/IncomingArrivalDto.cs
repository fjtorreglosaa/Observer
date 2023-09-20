namespace Observer.Application.Utilities.DTOs.Arrival
{
    public class IncomingArrivalDto
    {
        public Guid? SupplierId { get; set; }
        public string? Type { get; set; }
        public Guid? StoreId { get; set; }
        public List<Guid?> ItemIds { get; set; }
    }
}
