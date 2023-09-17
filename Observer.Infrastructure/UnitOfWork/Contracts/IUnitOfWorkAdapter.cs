namespace Observer.Infrastructure.UnitOfWork.Contracts
{
    public interface IUnitOfWorkAdapter
    {
        IUnitOfWorkRepository Repositories { get; }
        void Commit();
    }
}
