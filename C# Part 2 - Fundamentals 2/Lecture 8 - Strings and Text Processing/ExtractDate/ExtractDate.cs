//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDate
{
    static void Main()
    {
        string text = "Hello Pesho, yesterday was 2.02.2013 and today is 03.02.2013." +
                    "In 20 hours will be 04.02. and the exact time will be 08:36:12.";

        string pattern = @"([0-9]{2})(\.)([0-9]{2})(\.)([0-9]{4})";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (var match in matches)
        {
            DateTime date = DateTime.Parse(match.ToString());

            Console.WriteLine(date.ToString("d", new CultureInfo("en-CA")));
        }
    }
}