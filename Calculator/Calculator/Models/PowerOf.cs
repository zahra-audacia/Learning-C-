using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class PowerOf : IOperation
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public PowerOf(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public PowerOf()
        {
        }

        public char Operation => '^';
        public decimal Calculate()
        {
            return (decimal)Math.Pow((double) X, (double) Y);
        }
    }
}
