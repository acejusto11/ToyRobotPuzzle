namespace ToyRobotPuzzle.Helpers
{
    public interface IBasicParser
    {
        Command GetCommand(string[] input);
    }
}
