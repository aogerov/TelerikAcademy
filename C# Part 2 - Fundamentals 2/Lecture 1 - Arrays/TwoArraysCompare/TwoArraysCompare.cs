//Write a program that reads two arrays from the console and compares them element by element.

using System;

class TwoArraysCompare
{
    static void Main()
    {
        int[] firstArray;
        int[] secondArray;

        //read input
        Console.WriteLine("Enter the two arrays on separated lines with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        string lineOne = Console.ReadLine();
        string lineTwo = Console.ReadLine();
        string[] input;

        //first array initialization
        input = lineOne.Split(' ');
        firstArray = new int[input.Length];
        try
        {
            for (int index = 0; index < input.Length; index++)
            {
                firstArray[index] = int.Parse(input[index]);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Wrong input! Enter only numbers with one space between.");
            return;
        }

        //second array initialization
        input = lineTwo.Split(' ');
        secondArray = new int[input.Length];
        try
        {
            for (int index = 0; index < input.Length; index++)
            {
                secondArray[index] = int.Parse(input[index]);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Wrong input! Enter only numbers with one space between.");
            return;
        }

        //check for different length of arrays
        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Wrong input! Enter arrays with same size!");
            return;
        }

        //element comparing and print
        for (int index = 0; index < firstArray.Length; index++)
        {
            Console.WriteLine("{0} > {1} -> {2}", firstArray[index], secondArray[index], firstArray[index] > secondArray[index]);
        }
    }
}