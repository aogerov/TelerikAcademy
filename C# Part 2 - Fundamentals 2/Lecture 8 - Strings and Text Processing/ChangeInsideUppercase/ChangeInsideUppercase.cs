//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
//The tags cannot be nested. Example:
//      We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result:
//      We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text.RegularExpressions;

class ChangeInsideUppercase
{
    static string Matcher(Match match)
    {
        string output = String.Format("{0}{1}{2}", match.Groups[1].Value, match.Groups[2].Value.ToUpper(), match.Groups[3].Value);
        
        return output;
    }

    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string pattern = "(<upcase>)(.*?)(</upcase>)";

        string result = Regex.Replace(text, pattern, Matcher);

        Console.WriteLine("Original text:\r\n{0}\r\n", text);
        Console.WriteLine("Transformed text:\r\n{0}\r\n", result);
    }
}