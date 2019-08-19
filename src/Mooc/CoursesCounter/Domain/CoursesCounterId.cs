namespace src.Mooc.CoursesCounter.Domain
{
    using src.Shared.Domain.ValueObject;

    public class CoursesCounterId : Uuid
    {
        public CoursesCounterId(string value) : base(value)
        {
        }
    }
}