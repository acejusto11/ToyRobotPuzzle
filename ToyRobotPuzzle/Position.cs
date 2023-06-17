using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotPuzzle
{
    public class Position
    {
        [DefaultValue(0)]
        public int X { get; set; }

        [DefaultValue(0)]
        public int Y { get; set; }

        public Position(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
