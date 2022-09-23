using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Division : IOperation
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public Division(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public Division()
        {
        }

        public char Operation => '/';

        public decimal Calculate()
        {
            return X / Y;
        }
       
    }
}
