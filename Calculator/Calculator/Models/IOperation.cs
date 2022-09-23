using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public interface IOperation
    {
        
        decimal X { get; set; }

        decimal Y { get; set; }

        char Operation { get; }

        decimal Calculate();
       
    }
}
