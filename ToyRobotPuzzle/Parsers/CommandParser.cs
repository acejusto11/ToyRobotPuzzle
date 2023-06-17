using System;
using ToyRobotPuzzle.Helpers;
using System.Linq;

namespace ToyRobotPuzzle
{
    public class CommandParser : IBasicParser, IPlaceCommandParser
    {
        public Command GetCommand(string[] input)
        {
            Command command;
            Enum.TryParse(input[0], out command);
            return command;
        }

        public CommandValue GetParsedValues(string[] input)
        {
            const int placeCommandParameter = 3;
            Position position = null;
            Direction direction;

            var placeCommands = input[1].Split(new[] { ',', ' ' });


            if (input.Length != 2)
                throw new Exception("Place command is incomplete. Format should be: PLACE X,Y,DIRECTION");
            if (placeCommands.Length != placeCommandParameter)
                throw new Exception("Invalid number of parameters. Format should be: PLACE X,Y,DIRECTION");


            if (!Enum.TryParse(placeCommands[placeCommands.Length - 1], out direction))
                throw new Exception("Invalid Direction. Values should be NORTH,EAST,SOUTH,WEST");

            int x = Convert.ToInt32(placeCommands[0]);
            int y = Convert.ToInt32(placeCommands[1]);

            position = new Position(x, y);

            Enum.TryParse(placeCommands[2], out direction);

            return new CommandValue(position, direction);
        }
    }
}
