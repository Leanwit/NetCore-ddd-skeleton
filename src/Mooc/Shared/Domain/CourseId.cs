namespace src.Mooc.Shared.Domain
{
    using src.Shared.Domain.ValueObject;

    public class CourseId : Uuid
    {
        public CourseId(string value) : base(value)
        {
        }
    }
}