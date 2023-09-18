namespace Observer.Domain.Entities
{
    public class Bay : Entity
    {
        public Bay()
        {
            Levels = new HashSet<Level>();
        }

        public string? Identifier { get; set; }
        public Guid? AisleId { get; set; }
        public Aisle? Aisle { get; set; }
        public ICollection<Level> Levels { get; set; }
    }
}
