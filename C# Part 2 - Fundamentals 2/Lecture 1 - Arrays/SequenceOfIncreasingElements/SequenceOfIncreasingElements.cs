//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;
using System.Text;

class SequenceOfIncreasingElements
{
    static void Main()
    {
        int[] array;
        int longestNumberIndex = 0;
        int longestNumberCounter = 1;
        int number;
        int tempIndex;
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

        //finding the maximal sequence of equal elements with one loop
        for (int index = 0; index < array.Length; index++)
        {
            number = array[index];
            tempIndex = index;
            tempCount = 1;

            while (tempIndex < array.Length - 1)
            {
                if (number + 1 == array[tempIndex + 1])
                {
                    number++;
                    tempIndex++;
                    tempCount++;
                }
                else
                {
                    break;
                }
            }

            if (longestNumberCounter < tempCount)
            {
                longestNumberIndex = index;
                longestNumberCounter = tempCount;
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

        for (int index = longestNumberIndex; index < longestNumberIndex + longestNumberCounter; index++)
        {
            sb.Append(array[index]);
            if (index < longestNumberIndex + longestNumberCounter - 1)
            {
                sb.Append(",");
            }
        }
        sb.Append("}");
        Console.WriteLine(sb);
    }
}