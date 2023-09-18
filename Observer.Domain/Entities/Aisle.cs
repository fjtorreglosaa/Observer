namespace Observer.Domain.Entities
{
    public class Aisle : Entity
    {
        public Aisle()
        {
            Bays = new HashSet<Bay>();
        }

        public string? Identifier { get; set; }
        public Guid? WarehouseId { get; set; }
        public Warehouse? Warehouse { get; set; }
        public ICollection<Bay> Bays { get; set; }
    }
}
