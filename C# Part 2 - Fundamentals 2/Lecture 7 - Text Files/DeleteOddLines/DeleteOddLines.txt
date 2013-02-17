//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static string path = @"..\..\DeleteOddLines.txt";
    static string resultPath = @"..\..\result.txt";
    static string backup = @"..\..\backup.txt";
    static StringBuilder sb = new StringBuilder();

    static void FileReader()
    {
        string line;
        int counter = 1;

        using (StreamReader reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                if (counter % 2 == 0)
                {
                    if (counter > 3)
                    {
                        sb.Append("\r\n");
                    }

                    sb.Append(line);
                }

                counter++;
            }
        }
    }

    static void FileWriter()
    {
        using (StreamWriter writer = new StreamWriter(resultPath))
        {
            writer.Write(sb.ToString());
        }

        File.Replace(resultPath, path, backup);
        File.Delete(backup);

        Console.WriteLine("All odd lines are deleted!\r\n");
    }

    static void Main()
    {

        try
        {
            FileReader();

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