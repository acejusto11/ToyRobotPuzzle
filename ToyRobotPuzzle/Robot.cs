using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotPuzzle
{
    public class Robot : IRobot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPlaced { get; set; }
        public Direction Direction { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Place(int x, int y, Direction direction)
        {
            if (x > 0 && y > 0 && direction != Direction.NONE) 
            {
                this.X = x;
                this.Y = y;
                this.Direction = direction;
            }
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
