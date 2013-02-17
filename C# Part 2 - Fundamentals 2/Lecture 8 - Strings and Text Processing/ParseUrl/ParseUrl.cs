//Write a program that parses an URL address given in the format:
//      [protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//      [protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"

using System;
using System.Text.RegularExpressions;

class ParseUrl
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";

        string protocol = url.Substring(0, url.IndexOf(':'));
        string server = Regex.Match(url, @"[www.]*[\w]+[.][\w]+").ToString();
        string resource = url.Substring(url.IndexOf(server) + server.Length);

        Console.WriteLine("[url] = \"{0}\"", url);
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        Console.WriteLine("[server] = \"{0}\", ", server);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}