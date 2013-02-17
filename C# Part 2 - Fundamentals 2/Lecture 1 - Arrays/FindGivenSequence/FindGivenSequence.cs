//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;
using System.Text;

class FindGivenSequence
{
    static void Main()
    {
        int[] numbers;
        string[] nums;
        string input;
        int S;
        int tempSum;
        int indexPosition = 0;
        int length = 0;
        bool foundSum = false;

        //array initialization
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        input = Console.ReadLine();
        //input = "4 3 1 4 2 5 8";
        
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

        //S initialization
        Console.Write("Enter S: ");
        input = Console.ReadLine();
        //input = "11";

        if (int.TryParse(input, out S))
        {
            S = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input! Program terminates.");
        }

        //scan for the given sum S
        for (int outsideIndex = 0; outsideIndex < numbers.Length; outsideIndex++)
        {
            tempSum = 0;
            
            for (int index  = outsideIndex; index < numbers.Length; index++)
            {
                tempSum = tempSum + numbers[index];
                if (tempSum == S)
                {
                    foundSum = true;
                    indexPosition = outsideIndex;
                    length = index - outsideIndex + 1;
                    break;
                }
            }

            if (foundSum)
            {
                break;
            }
        }

        //print output
        if (foundSum)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n\r\nS={");
            sb.Append(S);
            sb.Append("} -> {");

            for (int index = indexPosition; index < indexPosition + length; index++)
            {
                sb.Append(numbers[index]);

                if (index < indexPosition + length - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append("}");
            Console.WriteLine(sb);
        }
        else
        {
            Console.WriteLine("\r\nThe sum S={0} wasn't found.", S);
        }
    }
}
