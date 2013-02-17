//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

using System;
using System.Collections.Generic;
using System.IO;

class SortStrings
{
    static List<string> strings = new List<string>();

    static void FileReader(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {
                strings.Add(reader.ReadLine());
            }
        }
    }

    static void FileWriter(string resultPath)
    {
        using (StreamWriter writer = new StreamWriter(resultPath))
        {
            foreach (var str in strings)
            {
                writer.WriteLine(str);
            }

            Console.WriteLine("File created!\r\n");
        }
    }

    static void Main()
    {
        string path = @"..\..\input.txt";
        string resultPath = @"..\..\result.txt";

        try
        {
            FileReader(path);

            strings.Sort();

            FileWriter(resultPath);
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