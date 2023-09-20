namespace Observer.Application.Publishers.Contracts
{
    public interface IAlertPublisher
    {
        void Attach(IAlertSubscriber subscriber);
        void Detach(IAlertSubscriber subscriber);
        void Notify(Guid stockId, Guid alertId);
    }
}
