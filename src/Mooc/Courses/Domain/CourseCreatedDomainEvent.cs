namespace Mooc.Courses.Domain
{
    using System;
    using System.Buffers.Text;
    using System.Collections.Generic;
    using Shared.Domain.Bus.Event;

    public class CourseCreatedDomainEvent : DomainEvent
    {
        private string Name;
        private string Duration;

        public CourseCreatedDomainEvent(string aggregateId, string name, string duration, string eventId = null, string occurredOn = null) : base(aggregateId,
            eventId, occurredOn)
        {
            this.Name = name;
            this.Duration = duration;
        }

        public override string EventName()
        {
            return "course.created";
        }

        public override Dictionary<string, string> ToPrimitives()
        {
            return new Dictionary<string, string>()
            {
                {"name", this.Name},
                {"duration", this.Duration}
            };
        }

        public override DomainEvent FromPrimitive(string aggreateId, Dictionary<string, string> body, string eventId, string occurredOn)
        {
            return new CourseCreatedDomainEvent(aggreateId, body["name"], body["duration"], eventId, occurredOn);
        }
    }
}