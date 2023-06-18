using System;

namespace ToyRobotPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            var dimension = new TableDimension(Constants.RobotDimensionColumn, Constants.RobotDimensionRows);
            var robot = new Robot(dimension);
            var robotValidator = new RobotValidator(dimension);
            var robotSimulator = new Simulator(robot, dimension, robotValidator);

            while (running) 
            {
                Console.WriteLine($"{Environment.NewLine}Use the following commands to move the robot:");
                Console.WriteLine("PLACE <X>,<Y>,<DIRECTION>");
                Console.WriteLine("MOVE");
                Console.WriteLine("LEFT");
                Console.WriteLine("RIGHT");
                Console.WriteLine($"{Environment.NewLine}Please enter your command");
                var input = Console.ReadLine();

                try
                {
                    var result = robotSimulator.Process(input);
                    if (result.Message?.Length > 0)
                        Console.WriteLine(result.Message);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
