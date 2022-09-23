namespace Operators
{
    public class Arithmetic
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Muliplication(int a, int b)
        {
            return a * b;
        }
        //public static int Exponentiation(int a, int b)
        //{
        //    return a ^ b;
        //}
        //}
        public static int Modulus(int a, int b)
        {
            return a % b;
        }
        public static int Division(int a, int b)
        {
            return (a / b);
        }
        public static int Increment(int a)
        {
            return a++;
        }
        public static int Decrement(int a)
        {
            return a--;
        }
        public static (int quotient, int remainder) Mod(int dividend, int divisor)
        {
            var quotient = dividend / divisor;
            var remainder = dividend % divisor;
            return (quotient, remainder);
        }
        public static bool PerfectSquare(int a)
        {
            if (a >= 0)
            {
                double square = Math.Sqrt(a);
                return square * square == a;
            }
            return false;
        }
        public static void Fibonacci(int a)
        {
            var firstNumber = 0;
            var secondNumber = 1;
            Console.WriteLine(firstNumber + " " + secondNumber);
            for (int i = 2; i < a; i++)
            {
                var nextNumber = firstNumber + secondNumber;
                Console.WriteLine(nextNumber + " ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    } 

}