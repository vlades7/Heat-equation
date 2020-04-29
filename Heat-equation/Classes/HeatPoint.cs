using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heat_equation.Classes
{
    class HeatPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double U { get; set; }

        public HeatPoint(int x, int y, double u)
        {
            X = x;
            Y = y;
            U = u;
        }
    }
}
