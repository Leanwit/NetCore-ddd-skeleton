namespace src.Shared.Domain.Bus.Event
{
    using System.Collections.Generic;

    public interface EventBus
    {
        void Publish(List<DomainEvent> domainEvent);
    }
}