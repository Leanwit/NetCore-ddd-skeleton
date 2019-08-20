namespace src.Mooc.Courses.Infrastructure
{
    using System.Linq;
    using System.Threading.Tasks;
    using Domain;
    using Shared.Domain;

    public class EfCourseRepository : CourseRepository
    {
        private CourseContext Context;

        public EfCourseRepository(CourseContext context)
        {
            Context = context;
        }

        public async Task Save(Course course)
        {
            await this.Context.Courses.AddAsync(course);
            await this.Context.SaveChangesAsync();
        }

        public Course search(CourseId id)
        {
            return this.Context.Courses.FirstOrDefault(c => c.Id.Equals(id));
        }
    }
}