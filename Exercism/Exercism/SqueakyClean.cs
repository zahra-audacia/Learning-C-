

/*
namespace Exercism
{
    public class Identifier
    {
        public static string Clean(string identifier)
        {

            StringBuilder cleaned = new StringBuilder();
            string greekLowerCaseChars = "αβγδεζηθικλμνξοπρστυϕχψω";

            for (int i = 0; i < identifier.Length; i++)
            {
                if (identifier[i] == ' ')
                {
                    cleaned.Append('_');
                }
                else if (char.IsControl(identifier[i]))
                {
                    cleaned.Append("CTRL");
                }
                else if (identifier[i] == '-')
                {
                    cleaned.Append(char.ToUpper(identifier[i + 1]));
                    i++;
                }
                else if (char.IsLetter(identifier[i]) && !greekLowerCaseChars.Contains(identifier[i]))
                {
                    cleaned.Append(identifier[i]);
                }
            }
            return cleaned.ToString();
        }


        public class SavingsAccount
        {
            public static float InterestRate(decimal balance)
            {
                if (balance < 0)
                {
                    return 3.213F;
                }
                else if (balance > 0 && balance < 1000)
                {
                    return 0.5F;
                }
                else if (balance >= 1000 && balance < 5000)
                {
                    return 1.621F;
                }
                else
                {
                    return 2.475F;
                }
            }

            public static decimal Interest(decimal balance)
            {
                var result = balance * (decimal)InterestRate(balance);
                return result; 
            }

            public static decimal AnnualBalanceUpdate(decimal balance)
            {
                return balance + Interest(balance);
            }

            public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
            {
                int years = 0;
                while (balance < targetBalance)
                {
                        years += 1;
                        balance = AnnualBalanceUpdate(balance);
                }
                return years;
            }
            }


    public static class Triangle
        {
            public static bool CheckIsTriangle(double side1, double side2, double side3)
            {
                return (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2 && side1 > 0 && side2 > 0 && side3 > 0 );
            }

            public static bool IsScalene(double side1, double side2, double side3)
            {
                if (CheckIsTriangle(side1, side2, side3))
                {
                    if ((side1 != side2) && (side1 != side3))
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }

            public static bool IsIsosceles(double side1, double side2, double side3)
            {
                if (CheckIsTriangle(side1, side2, side3) && !IsEquilateral(side1, side2, side3))
                {
                    if (side1 == side2 || side1 == side2 || side1 == side3)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }

            public static bool IsEquilateral(double side1, double side2, double side3)
            {
                if (CheckIsTriangle(side1, side2, side3))
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }

        public static class ScrabbleScore
        {
            public static int Score(string input)
            {
                char[] OnePoint = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
                char[] TwoPoints = { 'D', 'G' };
                char[] ThreePoints = { 'B', 'C', 'M', 'P' };
                char[] FourPoints = { 'F', 'H', 'V', 'W', 'Y' };
                char[] FivePoints = { 'K' };
                char[] EightPoints = { 'J', 'X' };
                char[] TenPoints = { 'Q', 'Z' };

                int total = 0;

                string letters[] = input.Split("")
                
                foreach (letter in letters)
                {
                    if (OnePoint.Contains(letter))
                    {
                        total += 1;
                    }
                    else if (TwoPoints.Contains(letter))
                    {
                        total += 2;
                    }
                    else if (ThreePoints.Contains(letter))
                    {
                        total += 3;
                    }
                    else if (FourPoints.Contains(letter))
                    {
                        total += 4;
                    }
                    else if (FivePoints.Contains(letter))
                    {
                        total += 5;
                    }
                    else if (EightPoints.Contains(letter))
                    {
                        total += 8;
                    }
                    else if (TenPoints.Contains(letter))
                    {
                        total += 10;
                    }
                }
                return total;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public class Identifier
    {
        public static string Clean(string identifier)
        {

            StringBuilder cleaned = new StringBuilder();
            string greekLowerCaseChars = "αβγδεζηθικλμνξοπρστυϕχψω";

            for (int i = 0; i < identifier.Length; i++)
            {
                if (identifier[i] == ' ')
                {
                    cleaned.Append('_');
                }
                else if (char.IsControl(identifier[i]))
                {
                    cleaned.Append("CTRL");
                }
                else if (identifier[i] == '-')
                {
                    cleaned.Append(char.ToUpper(identifier[i + 1]));
                    i++;
                }
                else if (char.IsLetter(identifier[i]) && !greekLowerCaseChars.Contains(identifier[i]))
                {
                    cleaned.Append(identifier[i]);
                }
            }
            return cleaned.ToString();
        }


        public class SavingsAccount
        {
            public static float InterestRate(decimal balance)
            {
                if (balance < 0)
                {
                    return 3.213F;
                }
                else if (balance > 0 && balance < 1000)
                {
                    return 0.5F;
                }
                else if (balance >= 1000 && balance < 5000)
                {
                    return 1.621F;
                }
                else
                {
                    return 2.475F;
                }
            }

            public static decimal Interest(decimal balance)
            {
                var result = balance * (decimal)InterestRate(balance);
                return result; 
            }

            public static decimal AnnualBalanceUpdate(decimal balance)
            {
                return balance + Interest(balance);
            }

            public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
            {
                int years = 0;
                while (balance < targetBalance)
                {
                        years += 1;
                        balance = AnnualBalanceUpdate(balance);
                }
                return years;
            }
            }


    public static class Triangle
        {
            public static bool CheckIsTriangle(double side1, double side2, double side3)
            {
                return (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2 && side1 > 0 && side2 > 0 && side3 > 0 );
            }

            public static bool IsScalene(double side1, double side2, double side3)
            {
                if (CheckIsTriangle(side1, side2, side3))
                {
                    if ((side1 != side2) && (side1 != side3))
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }

            public static bool IsIsosceles(double side1, double side2, double side3)
            {
                if (CheckIsTriangle(side1, side2, side3) && !IsEquilateral(side1, side2, side3))
                {
                    if (side1 == side2 || side1 == side2 || side1 == side3)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }

            public static bool IsEquilateral(double side1, double side2, double side3)
            {
                if (CheckIsTriangle(side1, side2, side3))
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }

        public static class ScrabbleScore
        {
            public static int Score(string input)
            {
                char[] OnePoint = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
                char[] TwoPoints = { 'D', 'G' };
                char[] ThreePoints = { 'B', 'C', 'M', 'P' };
                char[] FourPoints = { 'F', 'H', 'V', 'W', 'Y' };
                char[] FivePoints = { 'K' };
                char[] EightPoints = { 'J', 'X' };
                char[] TenPoints = { 'Q', 'Z' };

                int total = 0;

                string letters[] = input.Split("")
                
                foreach (letter in letters)
                {
                    if (OnePoint.Contains(letter))
                    {
                        total += 1;
                    }
                    else if (TwoPoints.Contains(letter))
                    {
                        total += 2;
                    }
                    else if (ThreePoints.Contains(letter))
                    {
                        total += 3;
                    }
                    else if (FourPoints.Contains(letter))
                    {
                        total += 4;
                    }
                    else if (FivePoints.Contains(letter))
                    {
                        total += 5;
                    }
                    else if (EightPoints.Contains(letter))
                    {
                        total += 8;
                    }
                    else if (TenPoints.Contains(letter))
                    {
                        total += 10;
                    }
                }
                return total;
            }
        }
    }
}

*/ 
