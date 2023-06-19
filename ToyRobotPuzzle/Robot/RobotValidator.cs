using System;

namespace ToyRobotPuzzle
{
    public class RobotValidator: IValidator
    {
        private IDimension dimension;
        public RobotValidator(IDimension dimension) 
        {
            this.dimension = dimension;
        }

        public void CheckIfRobotIsInPlace(Position position, Command command)
        {
            if (position == null && command != Command.PLACE)
                throw new Exception(ErrorMessages.RobotIsNotInPlace);
        }

        public void ValidatePlaceParameters(Position position, Direction direction)
        {
            var isOutOFDimension = position.X > dimension.Columns || position.Y > dimension.Rows;

            if (isOutOFDimension || position.X < 0 || position.Y < 0)
            {
                throw new Exception(ErrorMessages.IncompletePlaceParameterPosition);
            }
        }
    }
}
