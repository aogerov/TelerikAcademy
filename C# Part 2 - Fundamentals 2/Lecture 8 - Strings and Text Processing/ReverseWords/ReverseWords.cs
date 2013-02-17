//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Text;

class ReverseWords
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi or any other language!";

        char[] splitters = { ' ', ',', '.', '!', '?', ';', ':' };

        string[] words = sentence.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        string[] separators = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            sentence = sentence.Remove(0, words[i].Length);

            if (i < words.Length - 1)
            {
                separators[i] = sentence.Substring(0, sentence.IndexOf(words[i + 1]));
                sentence = sentence.Remove(0, separators[i].Length);
            }
            else
            {
                separators[i] = sentence;
            }
        }

        StringBuilder reversed = new StringBuilder(sentence.Length);

        for (int i = 0; i < words.Length; i++)
        {
            reversed.Append(words[words.Length - i - 1]);
            reversed.Append(separators[i]);
        }

        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(reversed);
    }
}