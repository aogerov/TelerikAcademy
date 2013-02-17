//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Text;

class ArraySort
{
    static int[] numbers;

    static void InputReader()
    {
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        //string input = "4 2 76 5 34 33 102 38 7";
        string input = Console.ReadLine();
        string[] nums;

        nums = input.Split(' ');
        numbers = new int[nums.Length];
        try
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(nums[index]);
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Wrong input! Enter only numbers with one space between.");
            return;
        }
    }

    static int FindBiggestNumber(int index)
    {
        int workIndex = index;
        int minNumber = numbers[index];

        for (int insideIndex = index; insideIndex < numbers.Length - 1; insideIndex++)
        {
            if (minNumber > numbers[insideIndex + 1])
            {
                minNumber = numbers[insideIndex + 1];
                workIndex = insideIndex + 1;
            }
        }

        return workIndex;
    }

    static void SortArray()
    {
        int workIndex;
        int minNumber;

        if (numbers.Length > 1)
        {
            for (int index = 0; index < numbers.Length - 1; index++)
            {
                workIndex = FindBiggestNumber(index);
                minNumber = numbers[workIndex];

                for (int exchangeIndex = workIndex; exchangeIndex > index; exchangeIndex--)
                {
                    numbers[exchangeIndex] = numbers[exchangeIndex - 1];
                }

                numbers[index] = minNumber;
            }
        }
    }

    static void PrintOutput()
    {
        StringBuilder sb = new StringBuilder();
        for (int index = 0; index < numbers.Length; index++)
        {
            sb.Append(numbers[index]);
            if (index < numbers.Length - 1)
            {
                sb.Append(", ");
            }
        }
        Console.WriteLine(sb);
    }

    static void Main()
    {
        InputReader();

        SortArray();

        PrintOutput();
    }
}