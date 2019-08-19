namespace src.Mooc.CoursesCounter.Domain
{
    using System.Collections.Generic;
    using src.Shared.Domain.Bus.Event;

    public class CoursesCounterIncrementedDomainEvent : DomainEvent
    {
        public CoursesCounterIncrementedDomainEvent(string aggregateId, int total, string eventId = null, string occurredOn = null) : base(aggregateId, eventId,
            occurredOn)
        {
            Total = total;
        }

        public int Total { get; private set; }

        public override string EventName()
        {
            return "courses_counter.incremented";
        }

        public override Dictionary<string, string> ToPrimitives()
        {
            return new Dictionary<string, string>()
            {
                {"total", this.Total.ToString()}
            };
        }

        public override DomainEvent FromPrimitive(string aggreateId, Dictionary<string, string> body, string eventId, string occurredOn)
        {
            return new CoursesCounterIncrementedDomainEvent(aggreateId, int.Parse(body["total"]), eventId, occurredOn);
        }
    }
}