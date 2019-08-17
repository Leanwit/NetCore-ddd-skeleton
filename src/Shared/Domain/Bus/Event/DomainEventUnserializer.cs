namespace Shared.Domain.Bus.Event
{
    public interface DomainEventUnserializer
    {
        DomainEvent Unserialize(string domainEvent);

    }
}