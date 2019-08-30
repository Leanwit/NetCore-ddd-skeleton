namespace Test.Mooc.Courses.Domain
{
    using src.Mooc.Courses.Domain;
    using src.Mooc.Shared.Domain;

    public class CourseCreatedDomainEventMother
    {
        public static CourseCreatedDomainEvent Create(CourseId id, CourseName name, CourseDuration duration)
        {
            return new CourseCreatedDomainEvent(id.Value, name.Value, duration.Value);
        }

        public static CourseCreatedDomainEvent FromCourse(Course course)
        {
            return Create(course.Id, course.Name, course.Duration);
        }

        public static CourseCreatedDomainEvent Random()
        {
            return Create(CourseIdMother.Random(), CourseNameMother.Random(), CourseDurationMother.Random());
        }
    }
}