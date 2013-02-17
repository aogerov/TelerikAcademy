//Write a program that reads a string from the console and prints all different letters in the string
//along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class LettersCount
{
    static bool IsLetter(char current)
    {
        return Regex.IsMatch(current.ToString(), @"[a-zA-Z]");
    }

    static void Main()
    {
        string text = "Write a program that reads a string from the console and prints all different letters in the string " +
                        "along with information how many times each letter is found.";

        SortedDictionary<char, int> letters = new SortedDictionary<char, int>();

        char current;

        for (int i = 0; i < text.Length; i++)
        {
            current = text[i];

            if (IsLetter(current))
            {
                int value = 0;

                if (letters.ContainsKey(current))
                {
                    letters.TryGetValue(current, out value);
                    letters.Remove(current);
                }

                letters.Add(current, value + 1);
            }
        }

        foreach (var letter in letters)
        {
            Console.WriteLine("{0} -> {1} times", letter.Key, letter.Value);
        }
    }
}