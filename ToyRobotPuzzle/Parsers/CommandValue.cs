using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotPuzzle
{
    public class CommandValue
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public CommandValue(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }
    }
}
