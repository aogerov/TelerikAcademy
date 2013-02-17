//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEmail
{
    static void Main()
    {
        string text = "ma@hostname.com " +
                      "ma@hostname.comcom " +
                      "MA@hostname.coMCom " +
                      "m.a@hostname.co " +
                      "m_a1a@hostname.com " +
                      "ma-a@hostname.com " +
                      "ma-a@hostname.com.edu " +
                      "ma-a.aa@hostname.com.edu " +
                      "ma.h.saraf.onemore@hostname.com.edu " +
                      "ma12@hostname.com " +
                      "12@hostname.com " +
                      "Abc.example.com " +
                      "A@b@c@example.com " +
                      "ma...ma@jjf.co " +
                      "ma@jjf.c " +
                      "ma@jjf..com " +
                      "ma@@jjf.com " +
                      "@majjf.com " +
                      "ma.@jjf.com " +
                      "ma_@jjf.com " +
                      "ma.@jjf " +
                      "ma_@jjf. " +
                      "ma@jjf. ";

        string pattern = @"([\w\.\-]+)(@)([\w\-]+)(\.)(\w)+";
        //string pattern = @"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
