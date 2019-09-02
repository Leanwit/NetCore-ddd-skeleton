namespace Test.Mooc.CoursesCounter.Domain
{
    using src.Mooc.CoursesCounter.Domain;

    public class CoursesCounterIncrementedDomainEventMother
    {
        public static CoursesCounterIncrementedDomainEvent Create(CoursesCounterId id, CoursesCounterTotal total)
        {
            return new CoursesCounterIncrementedDomainEvent(id.Value, total.Value);
        }

        public static CoursesCounterIncrementedDomainEvent FromCounter(CoursesCounter counter)
        {
            return Create(counter.Id, counter.Total);
        }

        public static CoursesCounterIncrementedDomainEvent Random()
        {
            return Create(CoursesCounterIdMother.Random(), CoursesCounterTotalMother.Random());
        }
    }
}