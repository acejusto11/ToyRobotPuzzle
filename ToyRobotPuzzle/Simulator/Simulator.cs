using ToyRobotPuzzle.Interfaces;

namespace ToyRobotPuzzle
{
    public class Simulator : ICommand
    {
        private IRobot Robot;
        private IDimension Dimension;
        private IValidator Validator;

        public Simulator(IRobot robot, IDimension dimension, IValidator validator)
        {
            this.Robot = robot;
            this.Dimension = dimension;
            this.Validator = validator;
        }

        public Result Process(string inputCommand)
        {
            var commandParser = new CommandParser();
            var commands = inputCommand.Split(' ');
            var command = commandParser.GetCommand(commands);

            var resultMessage = new Result();

            Validator.CheckIfRobotIsInPlace(Robot.Position, command);

            switch (command)
            {
                case Command.PLACE:
                    var placeCommandValue = commandParser.GetParsedPositionValues(commands);

                    Validator.ValidatePlaceParameters(placeCommandValue.Position, placeCommandValue.Direction);
                    Robot.Place(placeCommandValue.Position, placeCommandValue.Direction);
                    break;
                case Command.MOVE:
                    Robot.Move();
                    break;
                case Command.LEFT:
                    Robot.Left();
                    break;
                case Command.RIGHT:
                    Robot.Right();
                    break;
                case Command.REPORT:
                    resultMessage.Message = $"***** The current position of the robot: {Robot?.Position?.X},{Robot?.Position?.Y} {Robot.Direction} *****";
                    break;
            }
            return resultMessage;
        }
    }
}
