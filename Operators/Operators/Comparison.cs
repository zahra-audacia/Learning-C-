using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Comparison
    {
        public static bool GreaterThan(int a, int b)
        {
            return a > b;
        }
        public static bool LessThan(int a, int b)
        {
            return a < b;
        }
        public static bool GreaterThanOrEqualTo(int a, int b)
        {
            return a >= b;
        }
        public static bool LessThanOrEqualTo(int a, int b)
        {
            return a <= b;
        }
        public static bool CheckInBetween(int a, int b, int c)
        {
            Console.WriteLine("I will check if " + b + " is in between " + a + " and " + c);

            return (a < b && c > b) || ( a > b && c < b);
            
        }
        public static string PositiveOrNegative(int a)
        {
            if (a < 0)
            {
                return ($"{a} is negative");
            }
            else if (a > 0)
            {
                return ($"{a} is positive");
            }
            else
            {
                return ($"{a} is neither positive or negative");
            }
        }
    }
}
