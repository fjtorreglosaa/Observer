namespace Observer.Domain.Entities
{
    public class Position : Entity
    {
        public Position()
        {
            Stocks = new HashSet<Stock>();
        }

        public string? Identifier { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public string? Type { get; set; }
        public Guid? LevelId { get; set; }
        public Level? Level { get; set; }
        public Guid? StockId { get; set; }
        public Stock? Stock { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
