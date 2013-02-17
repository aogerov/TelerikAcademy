using System;

class BiggerOfTwoIntegers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string input = Console.ReadLine();
        int firstNumber = int.Parse(input);
        
        Console.Write("Enter second number: ");
        input = Console.ReadLine();
        int secondNumber = int.Parse(input);
        
        bool firstIsBigger = (firstNumber > secondNumber);
        bool secondIsBigger = (firstNumber < secondNumber);
        bool numbersAreEqual = (firstNumber == secondNumber);
        
        Console.Write(firstIsBigger ? firstNumber + " > " + secondNumber : "");
        Console.Write(secondIsBigger ? firstNumber + " < " + secondNumber : "");
        Console.WriteLine(numbersAreEqual ? "Both numbers are equal!" : "");
    }
}