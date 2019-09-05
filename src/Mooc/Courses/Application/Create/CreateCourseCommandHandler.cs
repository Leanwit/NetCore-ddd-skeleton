namespace src.Mooc.Courses.Application.Create
{
    using Domain;
    using Shared.Domain;
    using src.Shared.Domain.Bus.Command;

    public class CreateCourseCommandHandler : CommandHandler
    {
        public CreateCourseCommandHandler(CourseCreator creator)
        {
            Creator = creator;
        }

        public CourseCreator Creator { get; private set; }

        public void Invoke(CreateCourseCommand command)
        {
            CourseId id = new CourseId(command.Id);
            CourseName name = new CourseName(command.Name);
            CourseDuration duration = new CourseDuration(command.Duration);

            this.Creator.Invoke(id, name, duration);
        }
    }
}