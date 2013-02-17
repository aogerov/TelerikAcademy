//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class LargestNumber
{
    static void Main()
    {   
        int minNumber;
        int workIndex;
        int K;
        int result;
        int[] numbers;

        //read input
        Console.Write("Enter K: ");
        K = int.Parse(Console.ReadLine());
        //K = 400;
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
        
        //searching for K and printing the result
        result = Array.BinarySearch(numbers, K);

        if (result >= 0)
        {
            Console.WriteLine("The number {0} existst in the array.", K);
        }
        else
        {
            result = (result * (-1)) - 2;

            if ((result >= 0) && (result < numbers.Length))
            {
                Console.WriteLine("The number {0} don't existst in the array. The one below it is {1}.", K ,numbers[result]);
            }
            else
            {
                Console.WriteLine("No solution found!");
            }
        }
    }
}