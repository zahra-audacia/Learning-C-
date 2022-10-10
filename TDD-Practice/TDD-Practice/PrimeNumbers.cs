using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practice
{
    public class PrimeNumbers
    {
        public List<int> GeneratePrimeNumbers(int n)
        {
            var primes = new List<int>() { 2 };
            int nextPrime = 3;
            if (n == 0)
            {
                return new List<int>() { };
            }
            else if (n < 0)
            {
                throw new ArgumentOutOfRangeException("input");
            }
            else
            {
                while(primes.Count < n)
                {
                    bool isPrime = true;

                    for (int i = 0; primes[i] <= Math.Sqrt(nextPrime); i++)
                    {
                        if (nextPrime % primes[i] == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primes.Add(nextPrime);
                    }
                    nextPrime += 2;
                }
                return primes;
                
            }
        }
    }
}
