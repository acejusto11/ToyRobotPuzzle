using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
