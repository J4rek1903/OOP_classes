using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_classes
{
    public static class MathShape
    {
        public static double GetArea(string shape = "", double lengthX= 0, double lengthY = 0)
        {
            if (string.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return lengthX * lengthY;
            }
            if (string.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(lengthX, 2);
            }
            if (string.Equals("Square", shape, StringComparison.OrdinalIgnoreCase))
            {
                return lengthX * lengthY;
            }
            if (string.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return lengthX * (lengthY / 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
