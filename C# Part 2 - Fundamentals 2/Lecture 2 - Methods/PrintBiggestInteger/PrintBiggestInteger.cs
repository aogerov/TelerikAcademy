//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class PrintBiggestInteger
{
    static int GetMax(int numOne, int numTwo)
    {
        if (numOne > numTwo)
        {
            return numOne;
        }
        else
        {
            return numTwo;
        }
    }

    static void Main()
    {
        int biggestNumber;

        //input reader
        Console.Write("Enter first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int numThree = int.Parse(Console.ReadLine());

        //find the biggest number
        biggestNumber = GetMax(GetMax(numOne, numTwo), numThree);

        //print the biggest number
        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
}