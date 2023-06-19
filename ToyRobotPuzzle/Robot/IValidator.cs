namespace ToyRobotPuzzle
{
    public interface IValidator
    {
        void ValidatePlaceParameters(Position position, Direction direction);
        void CheckIfRobotIsInPlace(Position position, Command command);

    }
}
