using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class BooleanLogicial
    {
        public static bool BothPostive(int a, int b)
        {
            return (a % 2 == 0  && b % 2 == 0 );
        }
        public static bool AtLeastOnePositive(int a, int b)
        {
            return (a % 2 == 0 || b % 2 == 0 );
        }
        public static bool NonePositive(int a, int b)
        {
            return (a % 2 != 0 && b % 2 != 0 );
        }
    }
}
