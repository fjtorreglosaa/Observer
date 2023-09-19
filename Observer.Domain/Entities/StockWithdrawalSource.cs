namespace Observer.Domain.Entities
{
    public class StockWithdrawalSource : Entity
    {
        public Guid? StockWithdrawalId { get; set; }
        public StockWithdrawal? StockWithdrawal { get; set; }
        public Guid? PositionId { get; set; }
        public Position Position { get; set; }
    }
}
