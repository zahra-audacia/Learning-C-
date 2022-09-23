using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;

namespace Calculator
{
    public class Calculator
    {
        public List<IOperation> Operations { get; set; } = new List<IOperation>();

        public void MyCalculator()
        
        {
            Console.WriteLine("How many operations would you like to perform? 1 or 2?");
            string numberOfOperationsInput = Console.ReadLine();
            var numberOfOperations = Convert.ToInt32(numberOfOperationsInput); 

            
            Console.WriteLine("Select the operation that you would like me to perform: ");
            Console.WriteLine("Addition");
            Console.WriteLine("Subtraction");
            Console.WriteLine("Division");
            Console.WriteLine("Multiplication");

            string userInput = Console.ReadLine();
            

            Console.WriteLine("Please give me your first number: ");

            string numberOneInput = Console.ReadLine(); 
            decimal numberOne = 0;
            bool success1 = decimal.TryParse(numberOneInput, out numberOne);

            Console.WriteLine("Please give me your second number: ");

            string numberTwoInput = Console.ReadLine();
            decimal numberTwo = 0;
            bool success2 = decimal.TryParse(numberTwoInput, out numberTwo); 

            if (numberOfOperations == 2)
            {
                Console.WriteLine("Please give me your third number: ");
                string numberThreeInput = Console.ReadLine();
            }
            
            if (success1 && success2)
            {
                if (userInput.ToLower() == "addition")
                {
                    Operations.Add(new Addition(numberOne, numberTwo));
                    
                }
                else if (userInput.ToLower() == "subtraction")
                {
                    Operations.Add(new Subtraction(numberOne, numberTwo));

                    
                }
                else if (userInput.ToLower() == "division")
                {
                    Operations.Add(new Division(numberOne, numberTwo));
                    
                }
                else if (userInput.ToLower() == "multiplication")
                {
                    Operations.Add(new Multiplication(numberOne, numberTwo));
                    
                }
                else
                {
                    Console.WriteLine("Not a valid operation");
                }

            }
            else
            {
                Console.WriteLine("Incorrect values entered");
            }

            decimal result = 0;
            foreach (var operation in Operations)
            {
                result = operation.Calculate();
            }
            
        }
    }
}
