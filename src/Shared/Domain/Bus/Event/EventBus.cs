namespace src.Shared.Domain.Bus.Event
{
    public interface EventBus
    {
        void Notify(DomainEvent domainEvent);
    }
}