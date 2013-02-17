//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class Palindromes
{
    static void Main()
    {
        string text = "ABBA hello,max!lamal - trust. Huh gog why... Unique/exe!";

        char[] separators = { ' ', ',', '.', '!', '?', '-', '/' };

        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            bool isPalindorme = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    isPalindorme = false;
                    break;
                }
            }

            if (isPalindorme)
            {
                Console.WriteLine(word);
            }
        }
    }
}