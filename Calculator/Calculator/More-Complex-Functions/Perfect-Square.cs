using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.More
{
    public class Perfect_Square
    {
        public bool CheckIfPerfectSquare(int value)
        {
            var a = Math.Sqrt(value);
            return a * a == value;
        }
    }
}
