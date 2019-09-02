namespace Test.Mooc.CoursesCounter.Domain
{
    using Shared.Domain;
    using src.Mooc.CoursesCounter.Domain;

    public class CoursesCounterIdMother
    {
        public static CoursesCounterId Create(string value)
        {
            return new CoursesCounterId(value);
        }

        public static CoursesCounterId Random()
        {
            return Create(UuidMother.Random());
        }
    }
}