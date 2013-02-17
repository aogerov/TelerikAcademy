//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:
//  <html>
//      <head><title>News</title></head>
//  <body>
//      <p><a href="http://academy.telerik.com">Telerik
//          Academy</a>aims to provide free real-world practical
//          training for young people who want to turn into
//          skillful .NET software engineers.</p>
//  </body>
//  </html>

using System;
using System.Text.RegularExpressions;

class ExtractHtmlText
{
    static void Main()
    {
        string text = "<html><head><title>News</title></head>" +
                        "<body><p><a href=\"http://academy.telerik.com\">>TelerikAcademy</a>" +
                        "aims to provide free real-world practical training for young people who want to turn into " +
                        "skillful .NET software engineers.</p></body></html>";

        string pattern = "(>)(.*?)(<)";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (var match in matches)
        {
            if (match.ToString().Length > 2)
            {
                Console.WriteLine(match.ToString().TrimStart('>').TrimEnd('<'));
            }
        }
    }
}