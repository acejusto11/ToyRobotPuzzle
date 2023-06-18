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

        public void Move()
        {
            switch (Direction) {
                case Direction.NORTH:
                    Position.Y = Position.Y < dimension.Columns ? Position.Y + 1: Position.Y;
                    break;
                case Direction.EAST:
                    Position.X = Position.X < dimension.Rows ? Position.X + 1: Position.X;
                    break;
                case Direction.SOUTH:
                    this.Position.Y = Position.Y > 0 ? Position.Y - 1: Position.Y;
                    break;
                case Direction.WEST:
                    this.Position.X = Position.X > 0 ? Position.X - 1: Position.X;
                    break;
            }
        }

        public void Place(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public void Left()
        {
            this.Direction = this.Direction == Direction.NORTH ? Direction.WEST : (Direction)Convert.ToInt32(this.Direction) - 1;
        }

        public void Right()
        {
            this.Direction = this.Direction == Direction.WEST ? Direction.NORTH : (Direction)Convert.ToInt32(this.Direction) + 1;
        }
    }
}
