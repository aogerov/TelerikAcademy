//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;
using System.Text;

class SequenceOfEqualElements
{
    static void Main()
    {
        int[] array;
        int longestNumber;
        int longestNumberCounter;
        int tempNumber;
        int tempCount;

        //read input
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        string input = Console.ReadLine();
        string[] numbers;

        //array initialization
        numbers = input.Split(' ');
        array = new int[numbers.Length];
        try
        {
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = int.Parse(numbers[index]);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Wrong input! Enter only numbers with one space between.");
            return;
        }

        //variables preparation
        longestNumber = array[0];
        longestNumberCounter = 1;
        tempNumber = array[0];
        tempCount = 1;

        //finding the maximal sequence of equal elements with one loop
        for (int index = 1; index < array.Length; index++)
        {
            if (tempNumber == array[index])
            {
                tempCount++;

                if (tempCount > longestNumberCounter)
                {
                    longestNumberCounter = tempCount;
                    longestNumber = tempNumber;
                }
            }
            else
            {
                tempNumber = array[index];
                tempCount = 1;
            }
        }

        //prining the sequence
        StringBuilder sb = new StringBuilder();
        sb.Append("{");
        for (int index = 0; index < array.Length; index++)
        {
            sb.Append(array[index]);
            if (index < array.Length - 1)
            {
                sb.Append(",");
            }
        }
        sb.Append("} -> {");
        for (int counter = 0; counter < longestNumberCounter; counter++)
        {
            sb.Append(longestNumber);
            if (counter < longestNumberCounter - 1)
            {
                sb.Append(",");
            }
        }
        sb.Append("}");
        Console.WriteLine(sb);
    }
}