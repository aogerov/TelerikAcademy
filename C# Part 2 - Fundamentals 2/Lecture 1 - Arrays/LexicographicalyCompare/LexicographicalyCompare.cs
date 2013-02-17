//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class LexicographicalyCompare
{
    static void Main()
    {
        char[] firstArray;
        char[] secondArray;

        //set arrays legth
        Console.Write("Enter the lenth of the arrays: ");
        int length = int.Parse(Console.ReadLine());
        firstArray = new char[length];
        secondArray = new char[length];

        //first array initialization
        Console.WriteLine("\r\nEnter the chars of the first array:");
        for (int index = 0; index < length; index++)
        {
            Console.Write("{0} of {1} -> ", index + 1, length);
            firstArray[index] = char.Parse(Console.ReadLine());
        }

        //second array initialization
        Console.WriteLine("\r\nEnter the chars of the second array");
        for (int index = 0; index < length; index++)
        {
            Console.Write("{0} of {1} -> ", index + 1, length);
            secondArray[index] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        //element comparing and print
        for (int index = 0; index < firstArray.Length; index++)
        {
            Console.WriteLine("{0} > {1} -> {2}", firstArray[index], secondArray[index], firstArray[index] > secondArray[index]);
        }
    }
}
