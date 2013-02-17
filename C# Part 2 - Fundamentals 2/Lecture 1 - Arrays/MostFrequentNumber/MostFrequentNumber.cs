//Write a program that finds the most frequent number in an array.
//Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;
using System.Collections.Generic;

class MostFrequentNumber
{
    static void Main()
    {
        int[] numbers;
        string[] nums;
        int outputCounter = 0;
        int outputNumber = 0;
        Dictionary<int, int> numbersCount = new Dictionary<int,int>();

        //read input
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        //string input = "4 1 1 4 2 3 4 4 1 2 4 9 3";
        string input = Console.ReadLine();

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

        //calculating the appearances
        foreach (var number in numbers)
        {
            int counter;
            if (numbersCount.TryGetValue(number, out counter))
            {
                numbersCount.Remove(number);
                numbersCount.Add(number, ++counter);
            }
            else
            {
                numbersCount.Add(number, 1);
            }
        }

        //find the highest appearance
        foreach (var numberCount in numbersCount)
        {
            if (numberCount.Value > outputCounter)
            {
                outputCounter = numberCount.Value;
                outputNumber = numberCount.Key;
            }
        }

        //print output
        Console.WriteLine("\r\nResult: {0} ({1} times)", outputNumber, outputCounter);
    }
}