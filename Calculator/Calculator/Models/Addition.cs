using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Addition : IOperation
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public Addition(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public Addition()
        {
        }

        public char Operation => '+';

        public decimal Calculate()
        {
            
            return X + Y;
        }
        

    }
}
