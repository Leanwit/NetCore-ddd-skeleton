namespace src.Mooc.Courses.Domain
{
    using System.Threading.Tasks;
    using Shared.Domain;

    public interface CourseRepository
    {
        Task Save(Course course);
        Course search(CourseId id);
    }
}