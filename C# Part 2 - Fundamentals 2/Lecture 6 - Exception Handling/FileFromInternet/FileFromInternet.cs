//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
//Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class FileFromInternet
{
    static void Main()
    {
        string address = "http://www.devbg.org/img/Logo-BASD.jpg";
        string fileName = "Logo.jpg";

        WebClient client = new WebClient();

        try
        {
            client.DownloadFile(address, fileName);
            Console.WriteLine("File downloaded. No errors occurred.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No-value provided for the web-address (or null value). Please specify a valid address.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The web-address name is empty. Please specify a valid address.");
        }
        catch (WebException)
        {
            Console.WriteLine("The URL was not found! Please make sure the address is correct and check your internet connection.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This operation is already performed by another method.");
        }
        finally
        {
            client.Dispose();
        }
    }
}