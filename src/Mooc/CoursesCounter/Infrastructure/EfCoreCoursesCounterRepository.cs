namespace src.Mooc.CoursesCounter.Infrastructure
{
    using System.Linq;
    using System.Threading.Tasks;
    using Domain;
    using EfCore;

    public class EfCoreCoursesCounterRepository : CoursesCounterRepository
    {
        private CoursesCounterContext Context;

        public EfCoreCoursesCounterRepository(CoursesCounterContext context)
        {
            Context = context;
        }

        public async Task Save(CoursesCounter counter)
        {
            CoursesCounterEfCoreModel courseCounter = new CoursesCounterEfCoreModel();
            courseCounter.Id = counter.Id.Value;
            courseCounter.Total = counter.Total.Value;
            courseCounter.ExistingCourses = counter.ExistingCourses;

            await this.Context.CoursesCounter.AddAsync(courseCounter);
            await this.Context.SaveChangesAsync();
        }

        public CoursesCounter Search()
        {
            CoursesCounterEfCoreModel courseCounter = this.Context.CoursesCounter.FirstOrDefault();

            return courseCounter != null
                ? new CoursesCounter(new CoursesCounterId(courseCounter.Id), new CoursesCounterTotal(courseCounter.Total), courseCounter.ExistingCourses)
                : null;
        }
    }
}