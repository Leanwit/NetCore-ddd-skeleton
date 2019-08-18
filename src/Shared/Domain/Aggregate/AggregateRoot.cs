namespace src.Shared.Domain.Aggregate
{
    using System.Collections.Generic;
    using Bus.Event;

    public abstract class AggregateRoot
    {
        private List<DomainEvent> DomainEvents = new List<DomainEvent>();

        public List<DomainEvent> PullDomainEvent()
        {
            var domainEvent = this.DomainEvents;
            this.DomainEvents = new List<DomainEvent>();

            return domainEvent;
        }

        protected void Record(DomainEvent domainEvent)
        {
            this.DomainEvents.Add(domainEvent);
        }
    }
}