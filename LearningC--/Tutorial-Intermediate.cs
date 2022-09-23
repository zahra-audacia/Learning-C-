using System;
using System.Text;

public class Example
{
    public string Strings()
    {

        StringBuilder example = new StringBuilder("Hello World");
    
        for(int i = 0; i < example.Length; i++)
            {
                Console.WriteLine(example[i]);
            }
    }
}

using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if (operand1 == 0 || operand2 == 0)
        {
            return "Division by zero is not allowed";
        }
        else if (operation == "+")
        {
            int addResult = operand1 + operand2;
            return $"{operand1} + {operand2} = {addResult}";
        }
        else if (operation == "*")
        {
            int multResult = operand1 * operand2;
            return $"{operand1} * {operand2} = {multResult}";
        }
        else if (operation == "/")
        {
            int divResult = (operand1 / operand2);
            return $"{operand1} / {operand2} = {divResult}";
        }
        else if (operation == null)
        {
            throw new ArgumentNullException();
        }
        else if (operation == "")
        {
            throw new ArgumentException();
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}

