namespace src.Mooc.Courses.Infrastructure
{
    using Domain;
    using Microsoft.EntityFrameworkCore;

    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}