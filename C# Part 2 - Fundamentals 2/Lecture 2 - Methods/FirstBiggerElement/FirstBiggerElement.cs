//Write a method that returns the index of the first element in array that is bigger than its neighbors,
//or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstBiggerElement
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
        //input = "1 2 3 4 5 6 7 8 9";

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

    static void CheckAllPositions()
    {
        for (int index = 0; index < numbers.Length; index++)
        {
            position = index;

            CheckPosition();

            if (isBigger == true)
            {
                break;
            }
        }
    }

    static void PrintOutput()
    {
        Console.WriteLine("\r\nArray elements: ");

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write(numbers[index]);

            if (index < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }

        if (isBigger)
        {
            Console.WriteLine("\r\nThe first element in array that is bigger than its neighbors is {0} with neighbors {1} and {2}.", numbers[position], numbers[position - 1], numbers[position + 1]);
        }
        else
        {
            Console.WriteLine("\r\nThere is no element in array that is bigger than its neighbors.");
        }
    }

    static void Main()
    {
        InputReader();

        CheckAllPositions();

        PrintOutput();
    }
}