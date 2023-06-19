using System;
using ToyRobotPuzzle.Helpers;

namespace ToyRobotPuzzle
{
    public class CommandParser : IBasicParser, IPlaceCommandParser
    {
        public Command GetCommand(string[] input)
        {
            return (Command)Enum.Parse(typeof(Command), input[0], false);
        }

        public CommandValue GetParsedPositionValues(string[] input)
        {
            const int placeCommandParameter = 3;
            Position position = null;
            Direction direction;

            if (input.Length != 2)
                throw new Exception(ErrorMessages.IncompletePlaceCommand);

            var placeCommands = input[1].Split(new[] { ',', ' ' });

            if (placeCommands.Length != placeCommandParameter)
                throw new Exception(ErrorMessages.IncompletePlaceParameters);
            if (!Enum.TryParse(placeCommands[2], out direction))
                throw new Exception(ErrorMessages.InvalidPlaceDirection);

            var x = Convert.ToInt32(placeCommands[0]);
            var y = Convert.ToInt32(placeCommands[1]);

            position = new Position(x, y);

            return new CommandValue(position, direction);
        }
    }
}
