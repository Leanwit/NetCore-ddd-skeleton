namespace Shared.Domain.Bus.Event
{
    public interface DomainEventSerializer
    {
        string Serialize(DomainEvent domainEvent);
    }
}