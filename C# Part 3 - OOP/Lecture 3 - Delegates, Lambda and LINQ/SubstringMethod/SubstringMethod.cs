//Implement an extension method Substring(int index, int length) for the class StringBuilder
//that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Text;

static class SubstringMethod
{
    public static string Substring(this StringBuilder input, int startIndex, int length)
    {
        StringBuilder sb = new StringBuilder(length);

        for (int i = startIndex; i < startIndex + length; i++)
        {
            sb.Append(input[i]);
        }

        return sb.ToString();
    }
}