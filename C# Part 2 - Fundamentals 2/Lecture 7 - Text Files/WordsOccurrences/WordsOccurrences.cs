﻿//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordsOccurrences
{
    static string pathText = @"..\..\test.txt";
    static string pathWords = @"..\..\words.txt";
    static string resultPath = @"..\..\result.txt";

    static string text;
    static List<string> words = new List<string>();
    static Dictionary<string, int> counts = new Dictionary<string, int>();

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

    static void CountWords()
    {
        int count;
        int indexOf;

        for (int index = 0; index < words.Count; index++)
        {
            count = 0;
            indexOf = text.IndexOf(words[index]);

            while (indexOf >= 0)
            {
                count++;
                indexOf = text.IndexOf(words[index], ++indexOf);
            }

            if (count > 0)
            {
                counts.Add(words[index], count);
            }
        }

        counts = counts.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    }

    static void FileWriter()
    {
        string line;
        int length = counts.Count;

        using (StreamWriter writer = new StreamWriter(resultPath))
        {
            foreach (var count in counts)
            {
                line = count.Key + " -> " + count.Value + " times";
                writer.Write(line);
                length--;

                if (length > 0)
                {
                    writer.WriteLine();
                }
            }
        }

        Console.WriteLine("Word occurrences caculated. Result file created.\r\n");
    }

    static void Main()
    {
        try
        {
            FileReader();

            CountWords();

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