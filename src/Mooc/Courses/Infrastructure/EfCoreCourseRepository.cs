namespace src.Mooc.Courses.Infrastructure
{
    using System.Linq;
    using System.Threading.Tasks;
    using Domain;
    using EfCore;
    using Shared.Domain;

    public class EfCoreCourseRepository : CourseRepository
    {
        private CourseContext Context;

        public EfCoreCourseRepository(CourseContext context)
        {
            Context = context;
        }

        public async Task Save(Course course)
        {
            CourseEfCoreModel courseModel = new CourseEfCoreModel();
            courseModel.Id = course.Id.Value;
            courseModel.Name = course.Name.Value;
            courseModel.Duration = course.Duration.Value;

            await this.Context.Courses.AddAsync(courseModel);
            await this.Context.SaveChangesAsync();
        }

        public Course search(CourseId id)
        {
            CourseEfCoreModel courseModel = this.Context.Courses.FirstOrDefault(c => c.Id.Equals(id.Value));
            return courseModel != null
                ? new Course(new CourseId(courseModel.Id), new CourseName(courseModel.Name), new CourseDuration(courseModel.Duration))
                : null;
        }
    }
}