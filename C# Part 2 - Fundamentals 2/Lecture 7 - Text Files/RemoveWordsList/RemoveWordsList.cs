//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWordsList
{
    static string pathText = @"..\..\text.txt";
    static string pathWords = @"..\..\words.txt";
    static string resultPath = @"..\..\result.txt";

    static string text;
    static List<string> words = new List<string>();

    static void FileReader()
    {
        using (StreamReader reader = new StreamReader(pathText))
        {
            text = reader.ReadToEnd();
        }

        string line;
        string[] occurrences;

        using (StreamReader reader = new StreamReader(pathWords))
        {
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                occurrences = line.Split(' ');

                foreach (var occurrence in occurrences)
                {
                    words.Add(occurrence);
                }
            }
        }
    }

    static void RemoveWords()
    {
        foreach (var word in words)
        {
            text = Regex.Replace(text, word, String.Empty);
        }
    }

    static void FileWriter()
    {
        string backup = @"..\..\backup.txt";

        using (StreamWriter writer = new StreamWriter(resultPath))
        {
            writer.Write(text);
        }

        File.Replace(resultPath, pathText, backup);
        File.Delete(backup);

        Console.WriteLine("All listed words are removed!\r\n");
    }

    static void Main()
    {
        try
        {
            FileReader();

            RemoveWords();

            FileWriter();
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
    }
}
