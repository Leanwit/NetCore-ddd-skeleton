namespace Test.Mooc.Courses.Domain
{
    using src.Mooc.Courses.Application.Create;
    using src.Mooc.Courses.Domain;
    using src.Mooc.Shared.Domain;

    public class CourseMother
    {
        public static Course Create(CourseId id, CourseName name, CourseDuration duration)
        {
            return new Course(id, name, duration);
        }

        public static Course FromRequest(CreateCourseCommand request)
        {
            return Create(CourseIdMother.Random(), CourseNameMother.Random(), CourseDurationMother.Random());
        }

        public static Course Random()
        {
            return Create(CourseIdMother.Random(), CourseNameMother.Random(), CourseDurationMother.Random());
        }
    }
}