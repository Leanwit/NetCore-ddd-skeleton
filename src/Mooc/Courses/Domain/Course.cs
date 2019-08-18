namespace src.Mooc.Courses.Domain
{
    using Shared.Domain;
    using src.Shared.Domain.Aggregate;

    public class Course : AggregateRoot
    {
        public CourseId Id { get; private set; }
        public CourseName Name { get; private set; }
        public CourseDuration Duration { get; private set; }

        public Course(CourseId id, CourseName name, CourseDuration duration)
        {
            Id = id;
            Name = name;
            Duration = duration;
        }

        public static Course Create(CourseId id, CourseName name, CourseDuration duration)
        {
            Course course = new Course(id, name, duration);
            
            course.Record(new CourseCreatedDomainEvent(id.Value,name.Value,duration.Value));

            return course;
        }
    }
}