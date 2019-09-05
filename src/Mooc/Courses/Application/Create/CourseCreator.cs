namespace src.Mooc.Courses.Application.Create
{
    using Domain;
    using Shared.Domain;
    using src.Shared.Domain.Bus.Event;

    public class CourseCreator
    {
        private EventBus Bus;
        private CourseRepository Repository;

        public CourseCreator(CourseRepository repository, EventBus bus)
        {
            Repository = repository;
            Bus = bus;
        }

        public void Invoke(CourseId id, CourseName name, CourseDuration duration)
        {
            Course course = Course.Create(id, name, duration);

            this.Repository.Save(course);
            this.Bus.Publish(course.PullDomainEvent());
        }
    }
}