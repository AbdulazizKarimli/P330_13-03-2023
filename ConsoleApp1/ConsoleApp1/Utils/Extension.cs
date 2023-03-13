namespace ConsoleApp1.Utils;

public static class Extension
{
    public static bool IsGreaterThan(this int number1, int number2)
    {
        return number1 > number2;
    }

    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsContainsDigit(this string word)
    {
        //1word
        foreach (char item in word)
        {
            if (char.IsDigit(item))
            {
                return true;
            }
        }

        return false;
    }
}