namespace src.Mooc.Courses.Application.Create
{
    using Domain;
    using Shared.Domain;
    using src.Shared.Domain.Bus.Event;

    public class CourseCreator
    {
        private CourseRepository Repository;
        private DomainEventPublisher Publisher;

        public CourseCreator(CourseRepository repository, DomainEventPublisher publisher)
        {
            Repository = repository;
            Publisher = publisher;
        }

        public void Execute(CreateCourseRequest request)
        {
            CourseId id = new CourseId(request.Id);
            CourseName name = new CourseName(request.Name);
            CourseDuration duration = new CourseDuration(request.Duration);

            Course course = Course.Create(id, name, duration);
            
            this.Repository.Save(course);
            this.Publisher.Publish(course.PullDomainEvent());
        }
    }
}