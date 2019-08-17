namespace Shared.Domain.Bus.Event
{
    public interface EventBus
    {
        void Notify(DomainEvent domainEvent);
    }
}