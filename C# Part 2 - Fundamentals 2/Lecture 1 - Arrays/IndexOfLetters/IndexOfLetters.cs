//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[53];
        string word;

        //setting start service char. will be needed just for the array initialization.
        letters[0] = (char)64;

        //setting A-Z letters at indexes from 1 to 26 and a-z from 27 to 52
        for (int index = 1; index < letters.Length; index++)
        {
            if (index < 27)
            {
                letters[index] = (char)(letters[0] + index);
            }
            else
            {
                letters[index] = (char)(letters[0] + index + 6);
            }
        }

        //read a word from the console
        Console.Write("Enter a word: ");
        word = Console.ReadLine();

        //print letters indexes
        for (int index = 0; index < word.Length; index++)
        {
            Console.WriteLine("Letter {0} is at index {1}", word[index], Array.BinarySearch(letters, word[index]));
        }

        //testing assistance
        //Console.WriteLine();
        //for (int i = 1; i < letters.Length - 1; i++)
        //{
        //    Console.WriteLine("{0} -> {1}", i, letters[i]);
        //}
    }
}