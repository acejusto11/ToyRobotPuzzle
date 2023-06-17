using System;
using System.ComponentModel;

namespace ToyRobotPuzzle
{
    public class Robot : IRobot
    {
        public Position Position { get; set; }

        [DefaultValue(Direction.SOUTH)]
        public Direction Direction { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Place(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public void RotateLeft()
        {
            throw new NotImplementedException();
        }

        public void RotateRight()
        {
            throw new NotImplementedException();
        }
    }
}
