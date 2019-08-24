namespace src.Mooc.Courses.Infrastructure.EfCore
{
    using Microsoft.EntityFrameworkCore;

    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<CourseEfCoreModel> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEfCoreModel>()
                .ToTable("courses");

            modelBuilder.Entity<CourseEfCoreModel>()
                .HasKey(c => c.Id);
        }
    }
}