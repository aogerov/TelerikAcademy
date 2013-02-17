//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks. Example:
//      Microsoft announced its next generation PHP compiler today.
//      It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
//The expected result:
//      ********* announced its next generation *** compiler today.
//      It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text.RegularExpressions;

class ReplaceWordsWithAsterisks
{
    static string Matcher(Match match)
    {
        string result = match.Value.ToString();

        return result.Replace(result, "*".PadLeft(result.Length, '*'));
    }

    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today." +
                    "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] words = { "PHP", "CLR", "Microsoft" };

        Console.WriteLine("Input:\r\n\r\n{0}\r\n", text);

        foreach (var word in words)
        {
            string pattern = String.Format(@"(\b{0}\b)", word);

            text = Regex.Replace(text, pattern, Matcher);
        }

        Console.WriteLine("Output:\r\n\r\n{0}\r\n", text);
    }
}