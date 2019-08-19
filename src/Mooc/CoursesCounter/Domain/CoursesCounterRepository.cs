namespace src.Mooc.CoursesCounter.Domain
{
    public interface CoursesCounterRepository
    {
        void Save(CoursesCounter counter);

        CoursesCounter Search();
    }
}