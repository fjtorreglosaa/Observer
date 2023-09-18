namespace Observer.Application.Utilities.DTOs.Warehouse
{
    public class WarehouseDto
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Identifier { get; set; }
    }
}
