namespace src.Mooc.CoursesCounter.Infrastructure.EfCore
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using Shared.Domain;

    public class CoursesCounterContext : DbContext
    {
        public CoursesCounterContext(DbContextOptions<CoursesCounterContext> options) : base(options)
        {
        }

        public DbSet<CoursesCounterEfCoreModel> CoursesCounter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursesCounterEfCoreModel>()
                .ToTable("courses_counter");

            modelBuilder.Entity<CoursesCounterEfCoreModel>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<CoursesCounterEfCoreModel>()
                .Property(b => b.ExistingCourses)
                .HasColumnName("existing_courses")
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<CourseId>>(v));
        }
    }
}