using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Subtraction : IOperation
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public Subtraction(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public Subtraction()
        {
        }

        public char Operation => '-';
        public decimal Calculate()
        {
            return X - Y;
        }
        
    }
}
