using ToyRobotPuzzle.Interfaces;

namespace ToyRobotPuzzle
{
    public class Simulator : ICommand
    {
        private IRobot Robot;
        private IDimension Dimension;

        public Simulator(IRobot robot, IDimension dimension)
        {
            this.Robot = robot;
            this.Dimension = dimension;
        }

        public void Process(string inputCommand)
        {
            var commandParser = new CommandParser();
            var commands = inputCommand.Split(' ');
            var command = commandParser.GetCommand(commands);

            if (Robot.Position == null && command != Command.PLACE)
                throw new System.Exception("Please use the PLACE command first before proceeding to other commands");

            switch (command)
            {
                case Command.PLACE:
                    var placeCommandValue = commandParser.GetParsedValues(commands);
                    var robotValidator = new RobotValidator(Dimension);

                    robotValidator.ValidatePlace(placeCommandValue.Position, placeCommandValue.Direction);
                    Robot.Place(placeCommandValue.Position, placeCommandValue.Direction);

                    break;

                case Command.REPORT:
                    var result = $"The current position of the robot: {Robot?.Position?.X},{Robot?.Position?.Y} {Robot.Direction}";
                    break;

            }
        }
    }
}
