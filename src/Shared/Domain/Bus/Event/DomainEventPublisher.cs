namespace src.Shared.Domain.Bus.Event
{
    using System.Collections.Generic;

    public interface DomainEventPublisher
    {
        void Publish(List<DomainEvent> domainEvents);
    }
}