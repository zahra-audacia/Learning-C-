 using System;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {

        int countOpeningSquareBracket = 0;
        int countClosingSquareBracket = 0;
        int countOpeningSquigglyBracket = 0;
        int countClosingSquigglyBracket = 0;
        int countOpeningSmoothBracket = 0;
        int countClosingSmoothBracket = 0;

        foreach (char c in input)
        {
            switch (c)
            {
                case '[':
                    countOpeningSquareBracket += 1;
                    Console.WriteLine(countOpeningSquareBracket);
                    break;
                case ']':
                    countClosingSquareBracket += 1;
                    Console.WriteLine(countClosingSquareBracket);
                    break;
                case '{':
                    countOpeningSquigglyBracket += 1;
                    Console.WriteLine(countOpeningSquigglyBracket);
                    break;
                case '}':
                    countClosingSquigglyBracket += 1;
                    Console.WriteLine(countClosingSquigglyBracket);
                    break;
                case '(':
                    countOpeningSmoothBracket += 1;
                    Console.WriteLine(countOpeningSmoothBracket);
                    break;
                case ')':
                    countClosingSmoothBracket += 1;
                    Console.WriteLine(countClosingSmoothBracket);
                    break;
                default:
                    break;
            }
        }
        
        bool result = ((countOpeningSquareBracket == countClosingSquareBracket)&& (countOpeningSquigglyBracket == countClosingSquigglyBracket) && (countClosingSmoothBracket == countClosingSmoothBracket));
        Console.WriteLine(result);
        return result;
            

    }
}

// returns true for }{ , whioch should return false because it is not ordered correctly 
