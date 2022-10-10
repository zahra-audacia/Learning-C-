using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practice
{
    public class RomanNumerals
    {
        public string ConvertToRomanNumerals(int number)
        {
            string result = "";

            Dictionary<string, int> RomanNumbersDictionary = new Dictionary<string, int>();
            RomanNumbersDictionary.Add("I", 1);
            RomanNumbersDictionary.Add("IV", 4);
            RomanNumbersDictionary.Add("V", 5);
            RomanNumbersDictionary.Add("IX", 9);
            RomanNumbersDictionary.Add("X", 10);
            RomanNumbersDictionary.Add("XL", 40);
            RomanNumbersDictionary.Add("L", 50);
            RomanNumbersDictionary.Add("XC", 90);
            RomanNumbersDictionary.Add("C", 100);
            RomanNumbersDictionary.Add("CD", 400);
            RomanNumbersDictionary.Add("D", 500);
            RomanNumbersDictionary.Add("CM", 900);
            RomanNumbersDictionary.Add("M", 1000);

                if (number <= 0)
                {
                    throw new ArgumentOutOfRangeException("number must be greater than 0");
                }
            else
            {
                foreach( var item in RomanNumbersDictionary.Reverse())
                {
                    while (number >= item.Value)
                    {
                        result += item.Key;
                        number -= item.Value;
                    }
                }

            }
            return result;
        }
    }
}
