namespace Mooc.Courses.Domain
{
    using Shared.Domain.ValueObject;

    public class CourseId : IntValueObject
    {
        public CourseId(int value) : base(value)
        {
        }
    }
}