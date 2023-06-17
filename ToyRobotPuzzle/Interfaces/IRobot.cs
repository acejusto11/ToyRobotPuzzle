using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotPuzzle
{
    public interface IRobot
    {
        void Place(int x, int y, Direction direction);
        void Move();
        void RotateLeft();
        void RotateRight();
    }
}
