namespace src.Shared.Domain.Bus.Event
{
    using System;
    using System.Collections.Generic;
    using ValueObject;

    public abstract class DomainEvent
    {
        protected DomainEvent(string aggregateId, string eventId = null, string occurredOn = null)
        {
            AggregateId = aggregateId;
            EventId = eventId ?? Uuid.Random().ToString();
            OccurredOn = occurredOn ?? Utils.DateToString(DateTime.Now);
        }

        public string AggregateId { get; private set; }
        public string EventId { get; private set; }
        public string OccurredOn { get; private set; }

        public abstract string EventName();

        public abstract Dictionary<string, string> ToPrimitives();

        public abstract DomainEvent FromPrimitive(string aggreateId, Dictionary<string, string> body, string eventId, string occurredOn);
    }
}