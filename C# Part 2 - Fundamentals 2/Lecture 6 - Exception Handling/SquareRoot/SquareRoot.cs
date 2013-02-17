//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number".
//In all cases finally print "Good bye". Use try-catch-finally.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter some number: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}