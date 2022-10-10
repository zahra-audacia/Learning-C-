using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practice
{
    public class CalculateAreaOfACircle
    {
        public double CalculateArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("radius");
            }
            else
            {
                return radius * radius * 3.14159265;
            }
        }
    }
}
