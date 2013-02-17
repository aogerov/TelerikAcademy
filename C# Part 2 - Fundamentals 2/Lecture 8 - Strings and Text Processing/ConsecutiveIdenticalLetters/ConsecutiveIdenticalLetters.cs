//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;

class ConsecutiveIdenticalLetters
{
    static void Main()
    {
        string text = "Write aa program that reads a string from the console " +
            "and repplaceeess alll series of consecutive identical letters with a single onee.." +
            "\r\nExample: \"aaaaabbbbbcdddeeeedssaa\"";

        StringBuilder sb = new StringBuilder();

        sb.Append(text[0]);

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i - 1] != text[i])
            {
                sb.Append(text[i]);
            }
        }

        Console.WriteLine(sb);
    }
}