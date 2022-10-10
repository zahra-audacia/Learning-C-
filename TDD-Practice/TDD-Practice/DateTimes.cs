using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practice
{
    public class dateTimes
    {
        public double differenceBetweenTwoTimes(DateTime firstTime,  DateTime secondTime)
        {
            if (firstTime > secondTime)
            {
                TimeSpan diff = firstTime.Subtract(secondTime);
                return diff.TotalSeconds;
            }
            else
            {
                TimeSpan diff = secondTime.Subtract(firstTime);
                return diff.TotalSeconds;
            }
            
        }
    }
}
