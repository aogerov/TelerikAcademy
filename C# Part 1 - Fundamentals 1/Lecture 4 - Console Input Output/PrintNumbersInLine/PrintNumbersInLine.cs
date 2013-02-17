using System;

class PrintNumbersInLine
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        for (int i = 1; i <= number; i++)
        {
            if (i != number)
            {
                Console.Write(i + ", ");   
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}