namespace src.Mooc.CoursesCounter.Domain
{
    using System.Collections.Generic;
    using Shared.Domain;
    using src.Shared.Domain.Aggregate;

    public class CoursesCounter : AggregateRoot
    {
        public CoursesCounter(CoursesCounterId id, CoursesCounterTotal total, List<CourseId> existingCourses = null)
        {
            Id = id;
            Total = total;
            ExistingCourses = existingCourses ?? new List<CourseId>();
        }

        public CoursesCounterId Id { get; private set; }
        public CoursesCounterTotal Total { get; private set; }
        public List<CourseId> ExistingCourses { get; private set; }

        public static CoursesCounter Initialize(CoursesCounterId id)
        {
            return new CoursesCounter(id, CoursesCounterTotal.Initialize());
        }

        public void Increment(CourseId courseId)
        {
            this.Total = this.Total.Increment();
            this.ExistingCourses.Add(courseId);

            this.Record(new CoursesCounterIncrementedDomainEvent(this.Id.Value, this.Total.Value));
        }

        public bool HasIncremented(CourseId courseId)
        {
            return this.ExistingCourses.IndexOf(courseId) > -1;
        }
    }
}