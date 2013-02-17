using System;

class AstrologicalDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = 0;
        int digit = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int.TryParse((input[i].ToString()), out digit);
            if ((digit > 0) && (digit < 10))
            {
                number += digit;
            }
        }

        while (number > 9)
        {
            int tempNumber = number;
            number = 0;
            while (tempNumber > 0)
            {
                digit = tempNumber % 10;
                number = number + digit;
                tempNumber = tempNumber / 10;
            }
        }

        Console.WriteLine(number);
    }
}