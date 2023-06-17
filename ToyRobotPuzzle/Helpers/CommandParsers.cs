using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotPuzzle
{
    public static class CommandParsers
    {
        public static Command GetParsedCommand(string input)
        {
            var inputCollection = input?.Split(new string[] { " ", "," }, StringSplitOptions.None);

            Command command ;
            Enum.TryParse(inputCollection[0], out command);

            return command;
        }
    }
}
