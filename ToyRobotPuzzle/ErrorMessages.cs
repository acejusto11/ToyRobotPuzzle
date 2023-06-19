namespace ToyRobotPuzzle
{
    public static class ErrorMessages
    {
        public const string IncompletePlaceCommand = "Place command is incomplete. Format should be: PLACE X,Y,DIRECTION";
        public const string IncompletePlaceParameters = "Invalid number of parameters. Format should be: PLACE X,Y,DIRECTION";
        public const string InvalidPlaceDirection = "Invalid Direction. Values should be NORTH,EAST,SOUTH,WEST";
        public const string IncompletePlaceParameterPosition = "Invalid Place Parameter Position";
        public const string RobotIsNotInPlace = "Please use the PLACE command first before proceeding to other commands";
    }
}
