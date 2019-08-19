namespace src.Mooc.CoursesCounter.Application.Find
{
    using Domain;

    public class CoursesCounterFinder
    {
        private CoursesCounterRepository respository;

        public CoursesCounterFinder(CoursesCounterRepository respository)
        {
            this.respository = respository;
        }

        public CoursesCounterResponse Execute()
        {
            var counter = this.respository.Search();

            if (counter == null)
            {
                throw new CoursesCounterNotExist();
            }

            return new CoursesCounterResponse(counter.Total.Value);
        }
    }
}