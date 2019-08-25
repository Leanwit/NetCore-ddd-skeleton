namespace src.Mooc.CoursesCounter.Infrastructure.EfCore
{
    using System.Collections.Generic;
    using Shared.Domain;

    public class CoursesCounterEfCoreModel
    {
        public string Id { get; set; }
        public int Total { get; set; }
        public List<CourseId> ExistingCourses { get; set; }
    }
}