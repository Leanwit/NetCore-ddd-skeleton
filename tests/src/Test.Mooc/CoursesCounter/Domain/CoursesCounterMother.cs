namespace Test.Mooc.CoursesCounter.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using Courses.Domain;
    using Shared.Domain;
    using src.Mooc.CoursesCounter.Domain;
    using src.Mooc.Shared.Domain;

    public class CoursesCounterMother
    {
        public static CoursesCounter Create(CoursesCounterId id, CoursesCounterTotal total, List<CourseId> existingCourses)
        {
            return new CoursesCounter(id, total, existingCourses.ToList());
        }

        public static CoursesCounter WithOne(CourseId courseId)
        {
            return Create(CoursesCounterIdMother.Random(), CoursesCounterTotalMother.One(), new List<CourseId> {courseId});
        }

        public static CoursesCounter Incrementing(CoursesCounter existingCounter, CourseId courseId)
        {
            List<CourseId> coursesId = existingCounter.ExistingCourses;
            coursesId.Add(courseId);

            return Create(existingCounter.Id, CoursesCounterTotalMother.Create(existingCounter.Total.Value + 1), coursesId);
        }

        public static CoursesCounter Random()
        {
            return Create(CoursesCounterIdMother.Random(), CoursesCounterTotalMother.Random(), Repeater<CourseId>.Random(CourseIdMother.Random).ToList());
        }
    }
}