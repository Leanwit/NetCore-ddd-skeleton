namespace src.Mooc.CoursesCounter.Domain
{
    using System.Threading.Tasks;

    public interface CoursesCounterRepository
    {
        Task Save(CoursesCounter counter);

        CoursesCounter Search();
    }
}