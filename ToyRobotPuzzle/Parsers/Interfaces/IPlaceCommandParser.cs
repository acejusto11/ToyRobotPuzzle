namespace ToyRobotPuzzle.Helpers
{
    public interface IPlaceCommandParser
    {
        CommandValue GetParsedPositionValues(string[] input);
    }
}
