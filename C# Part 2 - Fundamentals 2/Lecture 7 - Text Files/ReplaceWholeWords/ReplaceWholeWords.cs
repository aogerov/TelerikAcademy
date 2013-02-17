//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
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

                        line = Regex.Replace(line, @"\bstart\b", "finish");

                        writer.WriteLine(line);
                    }
                }
            }

            File.Replace(resultPath, path, backup);
            File.Delete(backup);

            Console.WriteLine("All occurrences of the whole word \"start\" are replaced with the word \"finish\"!\r\n");
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