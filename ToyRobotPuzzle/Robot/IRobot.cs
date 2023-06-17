namespace ToyRobotPuzzle
{
    public interface IRobot
    {
        Position Position { get; set; }
        Direction Direction { get; set; }
        void Place(Position position, Direction direction);
        void Move();
        void RotateLeft();
        void RotateRight();
    }
}
