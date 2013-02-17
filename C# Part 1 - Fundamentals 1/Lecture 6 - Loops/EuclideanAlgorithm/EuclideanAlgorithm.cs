using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int tempResult = 1;
        int greatestCommonDivisor;

        if (firstNumber < secondNumber)
        {
            secondNumber = secondNumber + firstNumber;
            firstNumber = secondNumber - firstNumber;
            secondNumber = secondNumber - firstNumber;
        }

        while (true)
        {
            tempResult = firstNumber % secondNumber;
            if (tempResult == 0)
            {
                greatestCommonDivisor = secondNumber;
                break;
            }
            firstNumber = secondNumber;
            secondNumber = tempResult;
        }

        Console.WriteLine("The greatest common divisor is: {0}", greatestCommonDivisor);
    }
}
