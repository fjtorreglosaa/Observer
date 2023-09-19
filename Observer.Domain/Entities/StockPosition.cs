namespace Observer.Domain.Entities
{
    public class StockPosition : Entity
    {
        public Guid? StockId  { get; set; }
        public Stock? Stock { get; set; }
        public Guid? PositionId  { get; set; }
        public Position? Position  { get; set; }
    }
}
