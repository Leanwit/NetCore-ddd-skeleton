namespace src.Mooc.CoursesCounter.Application.Increment
{
    using Domain;
    using Shared.Domain;
    using src.Shared.Domain;
    using src.Shared.Domain.Bus.Event;

    public class CoursesCounterIncrementer
    {
        private DomainEventPublisher Publisher;
        private CoursesCounterRepository Repository;
        private UuidGenerator UuidGenerator;

        public CoursesCounterIncrementer(CoursesCounterRepository repository, UuidGenerator uuidGenerator, DomainEventPublisher publisher)
        {
            Repository = repository;
            UuidGenerator = uuidGenerator;
            Publisher = publisher;
        }

        public void Invoke(CourseId courseId)
        {
            var counter = this.Repository.Search() ?? this.InitializeCounter();

            if (!counter.HasIncremented(courseId))
            {
                counter.HasIncremented(courseId);

                this.Repository.Save(counter);

                this.Publisher.Publish(counter.PullDomainEvent());
            }
        }

        private CoursesCounter InitializeCounter()
        {
            return CoursesCounter.Initialize(new CoursesCounterId(this.UuidGenerator.Generate()));
        }
    }
}