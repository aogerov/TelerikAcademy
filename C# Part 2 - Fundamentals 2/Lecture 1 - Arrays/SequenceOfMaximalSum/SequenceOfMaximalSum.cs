//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Text;

class SequenceOfMaximalSum
{
    static void Main()
    {
        int[] numbers;
        int maxSum = int.MinValue;
        int maxSumIndex = 0;
        int maxSumLength = 0;
        int tempSum;

        //read input
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        //string input = "2 3 -6 -1 2 -1 6 4 -8 8";
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

        //find the maximal sum sequence with 2 loops
        for (int outsideIndex = 0; outsideIndex < numbers.Length; outsideIndex++)
        {
            tempSum = 0;

            for (int index = outsideIndex; index < numbers.Length; index++)
            {
                tempSum = tempSum + numbers[index];

                if (maxSum < tempSum)
                {
                    maxSum = tempSum;
                    maxSumIndex = outsideIndex;
                    maxSumLength = index - outsideIndex + 1;
                }
            }
        }

        //print output
        StringBuilder sb = new StringBuilder();
        sb.Append("\r\nOutput: {");
        for (int index = 0; index < numbers.Length; index++)
        {
            sb.Append(numbers[index]);
            if (index < numbers.Length - 1)
            {
                sb.Append(", ");
            }
        }
        sb.Append("} -> {");
        for (int index = maxSumIndex; index < maxSumIndex + maxSumLength; index++)
        {
            sb.Append(numbers[index]);
            if (index < maxSumIndex + maxSumLength - 1)
            {
                sb.Append(", ");
            }
        }
        sb.Append("}");
        Console.WriteLine(sb);
    }
}