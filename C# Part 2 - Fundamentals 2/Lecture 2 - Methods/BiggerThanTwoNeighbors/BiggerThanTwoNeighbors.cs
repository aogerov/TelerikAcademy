//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class BiggerThanTwoNeighbors
{
    static int[] numbers;
    static int position;
    static bool isBigger;

    static void InputReader()
    {
        string input;
        string[] nums;

        //read array
        Console.WriteLine("Enter array of numbers with one space between each number. Like on this exaple -> 4 2 76 34 102 7 etc...");
        input = Console.ReadLine();
        //input = "4 1 1 4 2 3 4 4 1 2 4 9 3";

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
            numbers = null;
            InputReader();
            return;
        }

        //read number
        Console.Write("Enter position: ");
        input = Console.ReadLine();
        //input = "11";

        //number initialization
        if (int.TryParse(input, out position) && (position >= 0))
        {
            position = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input!");
            numbers = null;
            InputReader();
            return;
        }
    }

    static void CheckPosition()
    {
        if ((position > 0) && (position < numbers.Length - 1))
        {
            if ((numbers[position] > numbers[position - 1]) && (numbers[position] > numbers[position + 1]))
            {
                isBigger = true;
            }
        }
    }

    static void PrintResult()
    {
        if (isBigger)
        {
            Console.WriteLine("{0} is bigger than its two neighbors {1} and {2}.", numbers[position], numbers[position - 1], numbers[position + 1]);
        }
        else
        {
            if ((position == 0) || (position >= numbers.Length - 1))
            {
                Console.WriteLine("Position {0} don't have two neighbors!", position);
            }
            else
            {
                Console.WriteLine("{0} is NOT bigger than its two neighbors {1} and {2}.", numbers[position], numbers[position - 1], numbers[position + 1]);
            }
        }
    }

    static void Main()
    {
        InputReader();

        CheckPosition();

        PrintResult();
    }
}