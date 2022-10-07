using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.More
{
    public class Fibonacci
    {
        public List<int> FibonacciSeries(int numberOfElements)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            List<int> result = new List<int>() {firstNumber,secondNumber};

            if (numberOfElements == 0)
            {
                List<int> none = new List<int>() {};
                return none;
            }
            else if (numberOfElements == 1)
            {
                List<int> first = new List<int>() {firstNumber};
                return first;
            }
            else
            {
                for (int i = 2; i < numberOfElements; i++)
                {
                    int nextNumber = firstNumber + secondNumber;
                    result.Add(nextNumber);
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            return result;

        }
    }
}
