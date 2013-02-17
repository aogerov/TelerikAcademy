//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" algorithm:
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Text;

class SortArray
{
    static void Main()
    {
        int minNumber;
        int workIndex;
        int[] numbers;

        //read input
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        //string input = "4 2 76 5 34 33 102 38 7";
        string input = Console.ReadLine();
        string[] nums;

        //array initialization
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

        //sort array
        if (numbers.Length > 1)
        {
            for (int index = 0; index < numbers.Length - 1; index++)
            {
                minNumber = numbers[index];
                workIndex = index;

                for (int insideIndex = index; insideIndex < numbers.Length - 1; insideIndex++)
                {
                    if (minNumber > numbers[insideIndex + 1])
                    {
                        minNumber = numbers[insideIndex + 1];
                        workIndex = insideIndex + 1;
                    }
                }

                for (int exchangeIndex = workIndex; exchangeIndex > index; exchangeIndex--)
                {
                    numbers[exchangeIndex] = numbers[exchangeIndex - 1];
                }

                numbers[index] = minNumber;
            }
        }

        //print output
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
}