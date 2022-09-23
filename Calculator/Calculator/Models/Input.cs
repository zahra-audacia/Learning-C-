using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    internal class Input
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public Input(string question)
        {
            Question = question;

        }
    }
}
