using System;
using System.ComponentModel;

namespace ToyRobotPuzzle
{
    public class Robot : IRobot
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        private IDimension dimension;
        public Robot(IDimension dimension) 
        {
            this.dimension = dimension;
        }

        public void Move(Position position, Direction direction)
        {
            switch (direction) {
                case Direction.NORTH:
                    position.Y = position.Y < dimension.Columns ? position.Y + 1:  position.Y;
                    break;
                case Direction.EAST:
                    position.X = position.X < dimension.Rows ? position.X + 1: position.X;
                    break;
                case Direction.SOUTH:
                    position.Y = position.Y > 0 ? position.Y - 1: position.Y;
                    break;
                case Direction.WEST:
                    position.X = position.X > 0 ? position.X - 1: position.X;
                    break;
            }
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
