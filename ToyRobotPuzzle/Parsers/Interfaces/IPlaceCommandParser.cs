namespace ToyRobotPuzzle.Helpers
{
    public interface IPlaceCommandParser
    {
        CommandValue GetParsedValues(string[] input);
    }
}
