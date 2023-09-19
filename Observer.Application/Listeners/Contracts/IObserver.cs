using System.Runtime.InteropServices.JavaScript;

namespace Observer.Application.Listeners.Contracts
{
    public interface IObserver
    {
        void Update(IPublisher subject);
    }
}
