namespace Mooc.Courses.Domain
{
    using Shared.Domain.Aggregate;

    public class Course : AggregateRoot
    {
        private CourseId Id { get; set; }
        private CourseName Name { get; set; }
        private CourseDuration Duration { get; set; }

        public Course(CourseId id, CourseName name, CourseDuration duration)
        {
            Id = id;
            Name = name;
            Duration = duration;
        }

        public static Course Create(CourseId id, CourseName name, CourseDuration duration)
        {
            Course course = new Course(id, name, duration);

            //course.Record(new d);

            return course;
        }
    }
}