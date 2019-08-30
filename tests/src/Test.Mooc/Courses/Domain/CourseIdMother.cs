namespace Test.Mooc.Courses.Domain
{
    using Shared.Domain;
    using src.Mooc.Shared.Domain;

    public class CourseIdMother
    {
        public static CourseId Create(string value)
        {
            return new CourseId(value);
        }

        public static CourseId Random()
        {
            return Create(UuidMother.Random());
        }
    }
}