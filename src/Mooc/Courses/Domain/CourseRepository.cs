namespace Mooc.Courses.Domain
{
    public interface CourseRepository
    {
        void Save(Course course);
        Course search(CourseId id);
    }
}