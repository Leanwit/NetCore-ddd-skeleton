namespace src.Mooc.Courses.Domain
{
    using Shared.Domain;

    public interface CourseRepository
    {
        void Save(Course course);
        Course search(CourseId id);
    }
}