namespace src.Mooc.Courses.Infrastructure.Persistence
{
    using Domain;
    using Shared.Domain;

    public class EFCourseRepository : CourseRepository

    {
        public void Save(Course course)
        {
            throw new System.NotImplementedException();
        }
   
        public Course search(CourseId id)
        {
            throw new System.NotImplementedException();
        }
    }
}