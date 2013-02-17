using System;

class DigitName
{
    static void Main()
    {
        Console.WriteLine("Enter digit between 0 and 9: ");
        string input = Console.ReadLine();
        int digit;
        if (int.TryParse(input, out digit))
        {
            digit = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Error! You've entered not an integer!");
            return;
        }

        switch (digit)
        {
            case 0: Console.WriteLine("{0} - zero", digit);
                break;
            case 1: Console.WriteLine("{0} - one", digit);
                break;
            case 2: Console.WriteLine("{0} - two", digit);
                break;
            case 3: Console.WriteLine("{0} - three", digit);
                break;
            case 4: Console.WriteLine("{0} - four", digit);
                break;
            case 5: Console.WriteLine("{0} - five", digit);
                break;
            case 6: Console.WriteLine("{0} - six", digit);
                break;
            case 7: Console.WriteLine("{0} - seven", digit);
                break;
            case 8: Console.WriteLine("{0} - eight", digit);
                break;
            case 9: Console.WriteLine("{0} - nine", digit);
                break;
            default: Console.WriteLine("Enter digit - between 0 and 9!");
                break;
        }
    }
}