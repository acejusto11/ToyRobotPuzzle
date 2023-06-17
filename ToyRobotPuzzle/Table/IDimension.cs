using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotPuzzle
{
    public interface IDimension
    {
        int Columns { get; set; }
        int Rows { get; set; }
    }
}
