namespace Observer.Domain.Entities
{
    public class Level : Entity
    {
        public Level()
        {
            Positions = new HashSet<Position>();
        }

        public string Identifier { get; set; }
        public Guid? BayId { get; set; }
        public Bay? Bay { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}
