namespace Shared.Domain.Bus.Event
{
    using System.Collections.Generic;
    using System.Linq;

    public class SyncDomainEventPublisher : DomainEventPublisher
    {
        private List<DomainEvent> Events = new List<DomainEvent>();
        private List<DomainEvent> PublishedEvents = new List<DomainEvent>();

        public void Publish(List<DomainEvent> domainEvents)
        {
            this.Record(domainEvents);

            this.PublishRecorded();
        }

        public void Record(List<DomainEvent> domainEvents)
        {
            this.Events.AddRange(domainEvents);
        }

        public void PublishRecorded()
        {
            this.PopEvents().ForEach(e => this.EventPublisher(e));
        }

        public List<DomainEvent> PopPublishEvents()
        {
            var events = this.PublishedEvents;
            this.PublishedEvents = new List<DomainEvent>();

            return events;
        }

        public bool HasEventsToPublish()
        {
            return this.PublishedEvents.Any();
        }

        private void EventPublisher(DomainEvent domainEvent)
        {
            this.PublishedEvents.Add(domainEvent);
        }

        private List<DomainEvent> PopEvents()
        {
            var events = this.Events;
            this.Events = new List<DomainEvent>();

            return events;
        }
    }
}