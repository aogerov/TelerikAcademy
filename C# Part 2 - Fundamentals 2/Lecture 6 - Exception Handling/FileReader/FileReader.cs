//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;
using System.Security;

class FileReader
{
    static string content;

    static string ReadFile()
    {
        Console.WriteLine(@"Enter file name along with its full file path (e.g. C:\WINDOWS\win.ini)");
        string path = Console.ReadLine();
        //string path = @"..\..\file.txt";

        return File.ReadAllText(path, System.Text.Encoding.GetEncoding("windows-1251"));
    }

    static void Main()
    {
        try
        {
            content = ReadFile();
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Path is null.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error caused because one of the following issues:");
            Console.WriteLine("- path specified a file that is read-only.");
            Console.WriteLine("- the operation is not supported on the current platform.");
            Console.WriteLine("- path specified a directory.");
            Console.WriteLine("- the caller does not have the required permission.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }

        Console.WriteLine(content);
    }
}
