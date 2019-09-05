namespace src.Shared.Domain.Bus.Command
{
    public interface CommandBus
    {
        void Dispatch(Command command);
    }
}