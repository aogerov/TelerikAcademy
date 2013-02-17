using System;

class IntDoubleString
{
    static void Main()
    {
        Console.Write("Enter integer, double or string: ");
        string inputString = Console.ReadLine();
        int inputInteger;
        double inputDouble;
        int selection = 0;

        if (int.TryParse(inputString, out inputInteger))
        {
            inputInteger = int.Parse(inputString);
            selection = 1;
        }
        if (double.TryParse(inputString, out inputDouble) && inputDouble - inputInteger != 0)
        {
            inputDouble = double.Parse(inputString);
            selection = 2;
        }

        switch (selection)
        {
            case 0: Console.WriteLine("Input string: \"{0}\"\r\nOutput string: \"{1}\"", inputString, inputString + "*");
                break;
            case 1: Console.WriteLine("Input integer: {0}\r\nOutput integer: {1}", inputInteger, inputInteger + 1);
                break;
            case 2: Console.WriteLine("Input double: {0}\r\nOutput double: {1}", inputDouble, inputDouble + 1);
                break;
            default: Console.WriteLine("Wrong input!");
                break;
        }
    }
}