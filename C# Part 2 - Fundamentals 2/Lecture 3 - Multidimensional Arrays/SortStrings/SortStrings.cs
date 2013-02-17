//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortStrings
{
    static void Main()
    {
        int minLength;
        int workIndex;
        string minWord;
        string[] words;

        //input reader
        Console.WriteLine("Enter array of strings with one space between each one. Like on this exaple -> hello my dear friend");
        string input = Console.ReadLine();
        //string input = "hello my dear old friend from Bulgaria";
        words = input.Split(' ');

        //sort array
        if (words.Length > 1)
        {
            for (int index = 0; index < words.Length - 1; index++)
            {
                minLength = words[index].Length;
                workIndex = index;
                minWord = words[index];

                for (int insideIndex = index; insideIndex < words.Length - 1; insideIndex++)
                {
                    if (minLength > words[insideIndex + 1].Length)
                    {
                        minLength = words[insideIndex + 1].Length;
                        workIndex = insideIndex + 1;
                        minWord = words[insideIndex + 1];
                    }
                }

                for (int exchangeIndex = workIndex; exchangeIndex > index; exchangeIndex--)
                {
                    words[exchangeIndex] = words[exchangeIndex - 1];
                }

                words[index] = minWord;
            }
        }

        //print strings
        Console.WriteLine("\r\nSorted words by length:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}