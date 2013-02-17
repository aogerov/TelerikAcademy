//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//      Example: The target substring is "in". The text is as follows:
//      We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight.
//      So we are drinking all the day. We will move out of it in 5 days.
//      The result is: 9.

using System;

class SubstringCounter
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine();
        //string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight." +
        //              "So we are drinking all the day. We will move out of it in 5 days.";

        Console.WriteLine("Enter the substring for searching: ");
        string substring = Console.ReadLine();
        //string substring = "in";

        text = text.ToLower();
        string strToLower = substring.ToLower();

        int index = -1;
        int counter = -1;

        while (true)
        {
            counter++;
            index = text.IndexOf(strToLower, index + 1);

            if (index == -1)
            {
                break;
            }
        }

        Console.WriteLine("\r\nThe substring \"{0}\" was {1} times found in text.\r\n", substring, counter);
    }
}
