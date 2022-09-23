using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
          int total = 0;
          foreach(int multiple in multiples)
            {
                for (int n = 1; multiple * n < max; n++)
                {
                    total += (multiple * n);
                    Console.WriteLine(total);
                    n++;
                }
            }
          return total;
        }
    }
}
