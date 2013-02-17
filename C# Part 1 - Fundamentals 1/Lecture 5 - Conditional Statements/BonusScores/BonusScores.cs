using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter digit between 1 and 9: ");
        string input = Console.ReadLine();
        int digit;

        if (int.TryParse(input, out digit))
        {
            digit = int.Parse(input);
        }

        switch (digit)
        {
            case 1:
            case 2:
            case 3: Console.WriteLine("Input {0}\r\nOutput: {1}", digit, digit * 10);
                break;
            case 4:
            case 5:
            case 6: Console.WriteLine("Input {0}\r\nOutput: {1}", digit, digit * 100);
                break;
            case 7:
            case 8:
            case 9: Console.WriteLine("Input {0}\r\nOutput: {1}", digit, digit * 1000);
                break;
            default: Console.WriteLine("Error! Enter digit between 1 and 9!");
                break;
        }
    }
}