//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Sample HTML fragment:
//      <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//      Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//To:
//      <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
//      Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;
using System.Text.RegularExpressions;

class ReplaceInHtml
{
    static string Matcher(Match match)
    {
        string result = "[URL=" + match.Groups[2].Value + "]" + match.Groups[4].Value + "[/URL]";
        return result;
    }

    static void Main()
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course." +
                        "Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        string firstPattern = "<a href=\"";
        string secondPattern = "\">";
        string thirdPattern = "</a>";

        string pattern = String.Format("({0})(.*?)({1})(.*?)({2})", firstPattern, secondPattern, thirdPattern);

        string output = Regex.Replace(input, pattern, Matcher);
        
        Console.WriteLine(output);
    }
}