namespace src.Mooc.CoursesCounter.Application.Find
{
    public class CoursesCounterResponse
    {
        public CoursesCounterResponse(int total)
        {
            Total = total;
        }

        public int Total { get; private set; }
    }
}