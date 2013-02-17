//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//      Hi!
//Expected output:
//      \u0048\u0069\u0021

using System;
using System.Text;

class ConvertToUnicode
{
    static void Main()
    {
        //Console.WriteLine("Enter some text:");
        //string text = Console.ReadLine();
        string text = "Hi!";

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            string hex = String.Format("{0:X}", (int)text[i]);
            sb.Append(@"\u");
            sb.Append(hex.PadLeft(4, '0'));
        }

        Console.WriteLine("Input:\r\n{0}\r\n", text);
        Console.WriteLine("Output:\r\n{0}\r\n", sb);
    }
}