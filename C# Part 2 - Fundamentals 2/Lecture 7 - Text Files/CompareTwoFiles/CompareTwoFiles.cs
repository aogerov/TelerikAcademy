//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTwoFiles
{
    static void CompareLines(string firstFile, string secondFile)
    {
        int lineCounter = 1;
        string lineFirstFile;
        string lineSecondFile;

        StreamReader firstReader = new StreamReader(firstFile);
        StreamReader secondReader = new StreamReader(secondFile);

        while ((!firstReader.EndOfStream) && (!secondReader.EndOfStream))
        {
            lineFirstFile = firstReader.ReadLine();
            lineSecondFile = secondReader.ReadLine();

            if (lineFirstFile.Equals(lineSecondFile))
            {
                Console.WriteLine("Line {0} is the same on both files.\r\n", lineCounter);
            }
            else
            {
                Console.WriteLine("Line {0} is different on both files:\r\nFirst file: {1}\r\nSecond file{2}\r\n", lineCounter, lineFirstFile, lineSecondFile);
            }

            lineCounter++;
        }

        firstReader.Close();
        secondReader.Close();
    }

    static void Main()
    {
        string firstFile = @"..\..\firstFile.txt";
        string secondFile = @"..\..\secondFile.txt";

        try
        {
            CompareLines(firstFile, secondFile);
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