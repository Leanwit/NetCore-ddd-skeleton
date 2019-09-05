namespace src.Mooc.Courses.Application.Create
{
    using src.Shared.Domain.Bus.Command;

    public class CreateCourseCommand : Command
    {
        public CreateCourseCommand(string id, string name, string duration)
        {
            Id = id;
            Name = name;
            Duration = duration;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Duration { get; private set; }
    }
}