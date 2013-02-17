//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;

class AlphabeticalOrder
{
    static void Main()
    {
        string text = "Write a program that reads a list of words separated by spaces " +
                        "and prints the list in an alphabetical order";

        string[] splittedText = text.Split(' ');

        List<string> words = new List<string>();

        foreach (var word in splittedText)
        {
            words.Add(word);
        }

        words.Sort();

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}