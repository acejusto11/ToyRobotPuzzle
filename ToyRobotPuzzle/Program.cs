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
                Console.WriteLine("Please enter your command");
                var input = Console.ReadLine();

                try
                {
                    robotSimulator.Process(input);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
