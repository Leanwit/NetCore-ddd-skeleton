namespace src.Mooc.Courses.Domain
{
    using src.Shared.Domain.ValueObject;

    public class CourseName : StringValueObject
    {
        public CourseName(string value) : base(value)
        {
        }
    }
}