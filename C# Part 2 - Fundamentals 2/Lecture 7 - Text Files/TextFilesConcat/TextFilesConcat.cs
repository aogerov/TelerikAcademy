//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class TextFilesConcat
{
    static string ReadFile(string path, string encoding)
    {
        string output;

        using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding(encoding)))
        {
            output = reader.ReadToEnd();
        }

        return output;
    }

    static void WriteFile(string text, string resultPath, string encoding)
    {
        using (StreamWriter writer = new StreamWriter(resultPath, false, Encoding.GetEncoding(encoding)))
        {
            writer.Write(text);
        }
    }

    static void Main()
    {
        string first = @"..\..\first.txt";
        string second = @"..\..\second.txt";
        string encoding = "windows-1251";

        StringBuilder outputText = new StringBuilder();
        string resultPath = @"..\..\result.txt";

        try
        {
            outputText.Append(ReadFile(first, encoding));
            outputText.Append("\r\n");
            outputText.Append(ReadFile(second, encoding));

            WriteFile(outputText.ToString(), resultPath, encoding);

            Console.WriteLine("File created!");
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
