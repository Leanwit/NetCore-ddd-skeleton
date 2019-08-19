namespace src.Mooc.CoursesCounter.Domain
{
    using src.Shared.Domain.ValueObject;

    public class CoursesCounterTotal : IntValueObject
    {
        public CoursesCounterTotal(int value) : base(value)
        {
        }

        public static CoursesCounterTotal Initialize()
        {
            return new CoursesCounterTotal(0);
        }

        public CoursesCounterTotal Increment()
        {
            return new CoursesCounterTotal(this.Value + 1);
        }
    }
}