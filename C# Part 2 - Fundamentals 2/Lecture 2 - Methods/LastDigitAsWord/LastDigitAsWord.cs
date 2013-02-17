//Write a method that returns the last digit of given integer as an English word.
//Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class LastDigitAsWord
{
    static string LastDigit(long number)
    {
        string digit = "Error!";

        switch (number % 10)
        {
            case 0: digit = "zero"; break;
            case 1: digit = "one"; break;
            case 2: digit = "two"; break;
            case 3: digit = "three"; break;
            case 4: digit = "four"; break;
            case 5: digit = "five"; break;
            case 6: digit = "six"; break;
            case 7: digit = "seven"; break;
            case 8: digit = "eight"; break;
            case 9: digit = "nine"; break;
            default:
                break;
        }

        return digit;
    }

    static void Main()
    {
        string input;
        long number;
        string lastDigit;

        //read input
        Console.Write("Enter some number: ");
        input = Console.ReadLine();
        if (long.TryParse(input, out number))
        {
            number = long.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input!");
            Main();
            return;
        }

        //read last digit with LastDigit();
        lastDigit = LastDigit(number);

        //print result
        Console.WriteLine("{0} -> {1}", number, lastDigit);
    }
}