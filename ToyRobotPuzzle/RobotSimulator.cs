using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotPuzzle.Interfaces;

namespace ToyRobotPuzzle
{
    public class RobotSimulator : ICommand
    {
        private string input;

        public RobotSimulator(string input)
        {
            this.input = input;
        }

        public void Process()
        {

            var robot = new Robot();
            var command = CommandParsers.GetParsedCommand(input);

            switch (command)
            {
                case Command.PLACE:
                    robot.Place(1, 1, Direction.NORTH);
                    break;

            }
        }
    }
}
