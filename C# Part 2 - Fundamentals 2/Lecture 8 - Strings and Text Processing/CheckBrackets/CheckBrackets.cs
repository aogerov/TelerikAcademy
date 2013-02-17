//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

class CheckBrackets
{
    static void Main()
    {
        Console.Write("Enter some expression: ");
        string expression = Console.ReadLine();
        //string expression = "((a+b)/5-d)";
        //string expression = ")(a+b))";

        int openingBracket = 0;
        int closingBracket = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                openingBracket++;
            }

            if (expression[i] == ')')
            {
                closingBracket++;
            }
        }

        if (openingBracket == closingBracket)
        {
            Console.WriteLine("\r\nThe expression {0} is correct.\r\n", expression);
        }
        else
        {
            Console.WriteLine("\r\nThe expression {0} is NOT correct.\r\n", expression);
        }
    }
}
