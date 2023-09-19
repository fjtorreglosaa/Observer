namespace Observer.Domain.Entities
{
    public class StockWithdrawal : Entity
    {
        public StockWithdrawal()
        {
            Sources = new HashSet<StockWithdrawalSource>();
        }

        public int? StockCount { get; set; }
        public Guid? StockId { get; set; }
        public Stock? Stock { get; set; }
        public Guid? WithdrawalId { get; set; }
        public Withdrawal? Withdrawal { get; set; }
        public string? Reason { get; set; }
        public ICollection<StockWithdrawalSource> Sources { get; set; }
    }
}
