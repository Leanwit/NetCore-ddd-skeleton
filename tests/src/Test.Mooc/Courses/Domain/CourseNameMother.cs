namespace Test.Mooc.Courses.Domain
{
    using Shared.Domain;
    using src.Mooc.Courses.Domain;

    public class CourseNameMother
    {
        public static CourseName Create(string value)
        {
            return new CourseName(value);
        }

        public static CourseName Random()
        {
            return Create(WordMother.Random());
        }
    }
}