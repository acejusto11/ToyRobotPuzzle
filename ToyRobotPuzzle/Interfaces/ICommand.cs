namespace ToyRobotPuzzle.Interfaces
{
    public interface ICommand
    {
        Result Process(string inputCommand);
    }
}
