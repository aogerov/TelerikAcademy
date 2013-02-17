//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        string path = @"..\..\info.txt";
        string encoding = "windows-1251";

        int counter = 1;
        string line;

        try
        {
            using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding(encoding)))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();

                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("Line {0} : {1}", counter, line);
                    }

                    counter++;
                }
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
    }
}