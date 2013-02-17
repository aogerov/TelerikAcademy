//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.

using System;

class ReadTwentyCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter some string: ");
        string input = Console.ReadLine();
        //string input = "12345678901234567";
        //string input = "12345678901234567890123";

        if (input.Length < 20)
        {
            Console.WriteLine(input.PadRight(20, '*'));
        }
        else
        {
            Console.WriteLine(input.Substring(0, 20));
        }
	}
}