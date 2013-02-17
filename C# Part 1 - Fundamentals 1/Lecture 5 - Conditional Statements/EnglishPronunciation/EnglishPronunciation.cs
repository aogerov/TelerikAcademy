using System;

class EnglishPronunciation
{
    static int firstDigit;
    static int secondDigit;
    static int thirdDigit;
    static int number;
    static string output;
    static bool validNumber;

    static void InputReader()
    {
        Console.WriteLine("Enter number in the range [0...999]");
        string input = Console.ReadLine();

        if (int.TryParse(input, out number) && number >= 0 && number < 1000)
        {
            number = int.Parse(input);
            validNumber = true;
        }
    }

    static void DigitsSplitter()
    {
        firstDigit = number % 10;
        if (number > 9)
        {
            secondDigit = number / 10;
            secondDigit %= 10;
        }
        if (number > 99)
        {
            thirdDigit = number / 100;
            thirdDigit %= 10;
        }
    }

    private static void ZeroToNine()
    {
        switch (firstDigit)
        {
            case 0: output += "zero";
                break;
            case 1: output += "one";
                break;
            case 2: output += "two";
                break;
            case 3: output += "three";
                break;
            case 4: output += "four";
                break;
            case 5: output += "five";
                break;
            case 6: output += "six";
                break;
            case 7: output += "seven";
                break;
            case 8: output += "eight";
                break;
            case 9: output += "nine";
                break;
            default:
                break;
        }
    }

    private static void TenToNineteen()
    {
        int tenToNineteen;
        if (number < 20)
        {
            tenToNineteen = number;
        }
        else
        {
            tenToNineteen = number - (thirdDigit * 100);
        }

        switch (tenToNineteen)
        {
            case 10: output += "ten";
                break;
            case 11: output += "eleven";
                break;
            case 12: output += "twelve";
                break;
            case 13: output += "thirteen";
                break;
            case 14: output += "fourteen";
                break;
            case 15: output += "fifteen";
                break;
            case 16: output += "sixteen";
                break;
            case 17: output += "seventeen";
                break;
            case 18: output += "eighteen";
                break;
            case 19: output += "nineteen";
                break;
            default:
                break;
        }
    }

    private static void TwentyToNinetyNine()
    {
        switch (secondDigit)
        {
            case 2: output += "twenty";
                break;
            case 3: output += "thirty";
                break;
            case 4: output += "fourty";
                break;
            case 5: output += "fifty";
                break;
            case 6: output += "sixty";
                break;
            case 7: output += "seventy";
                break;
            case 8: output += "eighty";
                break;
            case 9: output += "ninety";
                break;
            default:
                break;
        }

        if (firstDigit != 0)
        {
            output += " ";
            ZeroToNine();
        }
    }

    private static void Hundreds()
    {
        switch (thirdDigit)
        {
            case 1: output = "one hundred ";
                break;
            case 2: output = "two hundred ";
                break;
            case 3: output = "three hundred ";
                break;
            case 4: output = "four hundred ";
                break;
            case 5: output = "five hundred ";
                break;
            case 6: output = "six hundred ";
                break;
            case 7: output = "seven hundred ";
                break;
            case 8: output = "eight hundred ";
                break;
            case 9: output = "nine hundred ";
                break;
            default:
                break;
        }

        int reducedNumber = number - (thirdDigit * 100);
        if (reducedNumber >= 1 && reducedNumber <= 9)
        {
            output += "and ";
            ZeroToNine();
        }
        if (reducedNumber >= 10 && reducedNumber <= 19)
        {
            output += "and ";
            TenToNineteen();
        }
        if (reducedNumber >= 20)
        {
            TwentyToNinetyNine();
        }
    }

    static void Main()
    {
        InputReader();
        DigitsSplitter();

        if (number < 20)
        {
            if (number <= 9)
            {
                ZeroToNine();
            }
            else
            {
                TenToNineteen();
            }
        }
        else if ((number >= 20) && (number <= 99))
        {
            TwentyToNinetyNine();
        }
        else
        {
            Hundreds();
        }

        if (validNumber)
        {
            Console.WriteLine("{0} -> {1}", number, output);
        }
        else
        {
            Console.WriteLine("Error! Enter number in the range [0...999]!");
        }
    }
}
