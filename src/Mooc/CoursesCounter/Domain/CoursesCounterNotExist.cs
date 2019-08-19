namespace src.Mooc.CoursesCounter.Domain
{
    using Microsoft.CSharp.RuntimeBinder;

    public class CoursesCounterNotExist : RuntimeBinderException
    {
        public CoursesCounterNotExist() : base("The courses counter not exist")
        {
        }
    }
}