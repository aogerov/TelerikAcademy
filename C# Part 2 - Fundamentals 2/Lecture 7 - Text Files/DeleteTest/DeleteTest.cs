//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteTest
{
    static void Main()
    {
        string path = @"..\..\text.txt";
        string resultPath = @"..\..\result.txt";
        
        string pattern = @"test([\w]+)";
        
        string text;

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }

            text = Regex.Replace(text, pattern, String.Empty);

            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                writer.Write(text);
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

        Console.WriteLine("All occurrences of words with the prefix \"test\" are deleted. New file with the result created.\r\n");
    }
}