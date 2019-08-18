namespace Shared.Domain.Bus.Event
{
    using System;
    using System.Collections.Generic;
    using ValueObject;

    public abstract class DomainEvent
    {
        private string AggregateId { get; set; }
        private string EventId { get; set; }
        private string OccurredOn { get; set; }

        protected DomainEvent(string aggregateId, string eventId = null, string occurredOn = null)
        {
            AggregateId = aggregateId;
            EventId = eventId ?? Uuid.Random().ToString();
            OccurredOn = occurredOn ?? Utils.DateToString(DateTime.Now);
        }

        public abstract string EventName();
        
        public abstract Dictionary<string,string> ToPrimitives();
        
        public abstract DomainEvent FromPrimitive(string aggreateId, Dictionary<string, string> body, string eventId, string occurredOn);

    }
}