//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name>
//<age>21</age><interests count="3"><interest>
//Games</instrest><interest>C#</instrest><interest>
//Java</instrest></interests></student>


using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractWithoutTags
{
    static void Main()
    {
        string path = @"..\..\text.xml";

        string pattern = ">([^<]+)</";

        string input = "";

        string result;

        MatchCollection matches;

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadToEnd();
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Error! File not found exeption!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Error! Directory not found exeption!");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Error! I/O exeption!");
        }
        catch (Exception)
        {
            Console.Error.WriteLine("Fatal error!");
        }

        matches = Regex.Matches(input, pattern);

        foreach (var match in matches)
        {
            result = match.ToString();
            result = result.TrimStart('>');
            result = result.TrimEnd('/', '<');
            result = result.Trim();

            if (result.Length > 0)
            {
                Console.WriteLine(result);
            }
        }

        Console.WriteLine();
    }
}