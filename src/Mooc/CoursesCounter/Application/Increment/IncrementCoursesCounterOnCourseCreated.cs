namespace src.Mooc.CoursesCounter.Application.Increment
{
    using System.Collections.Generic;
    using Courses.Domain;
    using Shared.Domain;
    using src.Shared.Domain.Bus.Event;

    public class IncrementCoursesCounterOnCourseCreated : DomainEventSubscriber
    {
        private CoursesCounterIncrementer Incrementer;

        public IncrementCoursesCounterOnCourseCreated(CoursesCounterIncrementer incrementer)
        {
            Incrementer = incrementer;
        }

        public List<string> SubscribedTo()
        {
            return new List<string>() {nameof(CourseCreatedDomainEvent)};
        }


        public void Execute(CourseCreatedDomainEvent domainEvent)
        {
            CourseId courseId = new CourseId(domainEvent.AggregateId);

            this.Incrementer.Execute(courseId);
        }
    }
}