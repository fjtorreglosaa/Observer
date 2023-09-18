namespace Observer.Domain.Entities
{
    public class Withdrawal : Entity
    {
        public Withdrawal()
        {
            StockWithdrawals = new HashSet<StockWithdrawal>();
        }

        public string? Type { get; set; }
        public string? Description { get; set; }
        public ICollection<StockWithdrawal> StockWithdrawals { get; set; }
    }
}
