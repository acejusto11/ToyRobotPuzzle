﻿using System;
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
                throw new Exception("Place command is incomplete. Format should be: PLACE X,Y,DIRECTION");

            var placeCommands = input[1].Split(new[] { ',', ' ' });

            if (placeCommands.Length != placeCommandParameter)
                throw new Exception("Invalid number of parameters. Format should be: PLACE X,Y,DIRECTION");
            if (!Enum.TryParse(placeCommands[2], out direction))
                throw new Exception("Invalid Direction. Values should be NORTH,EAST,SOUTH,WEST");


            var x = Convert.ToInt32(placeCommands[0]);
            var y = Convert.ToInt32(placeCommands[1]);

            position = new Position(x, y);

            return new CommandValue(position, direction);
        }
    }
}
