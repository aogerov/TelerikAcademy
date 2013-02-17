//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceStartSubstrings
{
    static void Main()
    {
        string path = @"..\..\text.txt";
        string resultPath = @"..\..\result.txt";
        string backup = @"..\..\text Backup.txt";

        string line;

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(resultPath))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();

                        line = line.Replace("start", "finish");

                        writer.WriteLine(line);
                    }
                }
            }

            File.Replace(resultPath, path, backup);
            File.Delete(backup);

            Console.WriteLine("All occurrences of the substring \"start\" are replaced with the substring \"finish\"!\r\n");
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