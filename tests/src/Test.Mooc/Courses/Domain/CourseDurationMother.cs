namespace Test.Mooc.Courses.Domain
{
    using Shared.Domain;
    using src.Mooc.Courses.Domain;

    public class CourseDurationMother
    {
        public static CourseDuration Create(string value)
        {
            return new CourseDuration(value);
        }

        public static CourseDuration Random()
        {
            return Create($"{IntegerMother.Random()} {RandomElementPicker.From("months", "years", "days", "hours", "minutes", "seconds")}");
        }
    }
}