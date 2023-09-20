using System.Runtime.InteropServices.JavaScript;

namespace Observer.Application.Publishers.Contracts
{
    public interface IAlertSubscriber
    {
        Task Update(IAlertPublisher publisher, Guid stockId, Guid alertId);
    }
}
