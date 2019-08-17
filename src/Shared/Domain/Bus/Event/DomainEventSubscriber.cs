namespace Shared.Domain.Bus.Event
{
    using System.Collections.Generic;

    public interface DomainEventSubscriber
    {
        List<DomainEvent> SubscribedTo();
    }
}