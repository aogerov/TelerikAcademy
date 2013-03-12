using System;
using System.Text;

class TestProgram
{
    static void Main()
    {
        string s = "ABCDEF";
        string result;

        result = s.Substring(0, 2);
        Console.WriteLine("string.Substring() - {0}", result);

        StringBuilder sb = new StringBuilder();
        
        sb.Append(s);
        result = sb.Substring(0, 2);
        Console.WriteLine("StringBuilder.Substring() - {0}", result);
    }
}