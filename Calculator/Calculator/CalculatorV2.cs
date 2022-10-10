using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Operations;

namespace Calculator.Models
{
    public class CalculatorV2
    {
        // private var _input, which is of Type Input (we declared in another file)
        //private Input _input;

        private decimal _total;
        public decimal Total => _total;

        //private list of operations 
        private List<IOperation> _operations;


        public CalculatorV2()
            //constructor
        {
            _operations = new List<IOperation>()
            {
                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division()
            };
        }

        //Get User input => an expression that we will calculate. E.g. 3+5-4
        //public void GetInput()
        //{
        //    var expressionInput = new Input("Please enter the equation you would like me to calculate: ");
        //    Console.WriteLine(expressionInput.Question);
        //    expressionInput.Answer = Console.ReadLine();
        //    _input = expressionInput;
        //}

        //parsing and converting the input to check it is a valid expression 
        public decimal ParseInput(string input)
        {
            var AllInputsAreValid = true;

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i].ToString();
                if (currentChar == " ")
                {
                    continue;
                }
                if (i == 0)
                {
                    if (decimal.TryParse(currentChar, out var firstNumber))
                    {
                        _total = firstNumber;
                        continue;
                    }
                    else
                    {
                        AllInputsAreValid = false;
                    }

                }
                if (_operations.Any(o => o.Operation.ToString() == currentChar))
                {
                    var nextNumber = input[i + 1].ToString();
                    decimal.TryParse(nextNumber, out var number);

                    switch (currentChar)
                    {
                        case "+":
                            
                            var total_add = new Addition(_total, number);
                            _total = total_add.Calculate();
                            break;

                        case "-":
                            var total_sub = new Subtraction(_total, number);
                            _total = total_sub.Calculate();
                            break;

                        case "*":
                            var total_mult = new Multiplication(_total, number);
                            _total = total_mult.Calculate();
                            break;

                        case "/":
                            var total_div = new Division(_total, number);
                            _total = total_div.Calculate();
                            break;
                        case "^":
                            var total_pow = new PowerOf(_total, number);
                            _total = total_pow.Calculate();
                            break;
                        default:
                            break;
                    }
                }
                else if (!double.TryParse(currentChar, out var secondNumber))
                {
                    AllInputsAreValid = false;
                    break;
                }
                else
                {
                    AllInputsAreValid = false;
                }
            }
            return _total;
            
        }

    }
}
