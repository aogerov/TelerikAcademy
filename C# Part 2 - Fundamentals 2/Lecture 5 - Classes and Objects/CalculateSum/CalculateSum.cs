//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter some numbers separated by spaces: ");
        string[] numbers = Console.ReadLine().Split(' ');
        //string[] numbers = "43 68 9 23 318".Split(' ');

        int result = 0;

        foreach (var number in numbers)
        {
            if (number.Length > 0)
            {
                result = result + int.Parse(number);
            }
        }

        Console.WriteLine("\r\nResult = {0}\r\n", result);
    }
}