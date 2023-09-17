using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.UnitOfWork.Contracts
{
    public interface IUnitOfWork
    {
        IUnitOfWorkAdapter Create(string connectionString = null);
    }
}
