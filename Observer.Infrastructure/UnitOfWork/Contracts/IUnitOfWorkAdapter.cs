using Observer.Infrastructure.Repositories.Contracts;

namespace Observer.Infrastructure.UnitOfWork.Contracts
{
    public interface IUnitOfWorkAdapter : IDisposable
    {
        IUnitOfWorkRepository Repositories { get; }

        void Commit();
    }
}
