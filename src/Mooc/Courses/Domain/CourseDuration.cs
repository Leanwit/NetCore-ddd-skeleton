namespace src.Mooc.Courses.Domain
{
    using src.Shared.Domain.ValueObject;

    public class CourseDuration : StringValueObject
    {
        public CourseDuration(string value) : base(value)
        {
        }
    }
}