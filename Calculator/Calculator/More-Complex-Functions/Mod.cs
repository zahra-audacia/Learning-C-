using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.More
{
    public class Mod 
    {
        public List<decimal> ModFunction(decimal x, decimal y)
        {
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Values must be greater than 0");
                return new List<decimal> { 0, 0 };
            }
            else
            {
                decimal quod = Math.Floor(x / y);
                decimal rem = x % y;

                return new List<decimal> { quod, rem };
            }
        }
        
        public char Operation => '%';
       
       
    }
}
