//Write a program that reads a string from the console and lists all different words in the string
//along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordsCount
{
    static bool IsWord(string current)
    {
        return Regex.IsMatch(current, @"[a-zA-Z]+");
    }

    static void Main()
    {
        string text = "Write a program that reads a string from the console and lists all different words in the string " +
                        "along with information how many times each word is found.";

        char[] separators = { ' ', ',', '.', '!', '?', '-', '/' };

        string[] splittedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        SortedDictionary<string, int> words = new SortedDictionary<string, int>();

        foreach (var word in splittedText)
        {
            if (IsWord(word))
            {
                int value = 0;

                if (words.ContainsKey(word))
                {
                    words.TryGetValue(word, out value);
                    words.Remove(word);
                }

                words.Add(word, value + 1);
            }
        }

        foreach (var word in words)
        {
            if (word.Value > 1)
            {
                Console.WriteLine("{0} ->  {1} times", word.Key.PadRight(12, ' '), word.Value);
            }
            else
            {
                Console.WriteLine("{0} ->  {1} time", word.Key.PadRight(12, ' '), word.Value);
            }
        }
    }
}