//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

using System;

class NumberAppearance
{
    static int number;
    static int[] numbers;
    static int counts;
    static int expectedResult;

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
        Console.Write("Enter the number for count: ");
        input = Console.ReadLine();
        //input = "4";

        //number initialization
        if (int.TryParse(input, out number))
        {
            number = int.Parse(input);
        }
        else
        {
            Console.WriteLine("Wrong input!");
            numbers = null;
            InputReader();
            return;
        }
    }

    static void NumberCounter()
    {
        counts = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            if (number == numbers[index])
            {
                counts++;
            }
        }
    }

    static void PrintOutput()
    {
        Console.WriteLine("{0} appears {1} times in given array.", number, counts);
    }

    static void SingleTest()
    {
        NumberCounter();

        Console.Write("Number: {0} Expected result: {1}", number, expectedResult);
        
        if (expectedResult == counts)
        {
            Console.WriteLine(" -> Pass!");
        }
        else
        {
            Console.WriteLine(" -> Fail!");
        }

        Console.WriteLine();
    }

    static void TestProgram()
    {
        numbers = new int[] { 3, 4, 7, 5, 2, 0, 4, 6, 2, 5, 9, 1, 2 };

        //print array
        Console.WriteLine("\r\n---------------------------\r\n\r\nTest matrix:");

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write(numbers[index]);

            if (index < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("\r\n");

        //test 1
        number = 3;
        expectedResult = 1;
        SingleTest();

        //test 2
        number = 8;
        expectedResult = 0;
        SingleTest();

        //test 3
        number = 5;
        expectedResult = 2;
        SingleTest();

        //test 4
        number = 2;
        expectedResult = 3;
        SingleTest();

        //test 5
        number = 7;
        expectedResult = 1;
        SingleTest();
    }

    static void Main()
    {
        InputReader();

        NumberCounter();

        PrintOutput();

        TestProgram();
    }
}