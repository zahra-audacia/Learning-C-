using System;
using System.Linq;
public static class ScrabbleScore
{
    public static int Score(string input)
    {
        char[] OnePoint = new char[] { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
        char[] TwoPoints = new char[] { 'D', 'G' };
        char[] ThreePoints = new char[] { 'B', 'C', 'M', 'P' };
        char[] FourPoints = new char[] { 'F', 'H', 'V', 'W', 'Y' };
        char[] FivePoints = new char[] { 'K' };
        char[] EightPoints = new char[] { 'J', 'X' };
        char[] TenPoints = new char[] { 'Q', 'Z' };


        int total = 0;
        string letters = input.ToUpper();

        foreach (char letter in letters)
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