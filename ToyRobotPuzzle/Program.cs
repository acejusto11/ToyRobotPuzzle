using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = true;

            var robot = new Robot();

            while (run) 
            { 
                Console.WriteLine("Please enter your command");
                var input = Console.ReadLine();

                var robotSimulator = new RobotSimulator(input);

                robotSimulator.Process();
            }
        }
    }
}
