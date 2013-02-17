using System;

class FiveCount
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        
        Console.Write("Enter second integer: ");
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        
        int counter = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("p({0}, {1}) = {2}", firstNumber, secondNumber, counter);
    }
}