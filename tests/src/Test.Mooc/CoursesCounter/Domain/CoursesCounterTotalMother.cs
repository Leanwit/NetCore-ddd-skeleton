namespace Test.Mooc.CoursesCounter.Domain
{
    using Shared.Domain;
    using src.Mooc.CoursesCounter.Domain;

    public class CoursesCounterTotalMother
    {
        public static CoursesCounterTotal Create(int value)
        {
            return new CoursesCounterTotal(value);
        }

        public static CoursesCounterTotal One()
        {
            return Create(1);
        }

        public static CoursesCounterTotal Random()
        {
            return Create(IntegerMother.Random());
        }
    }
}