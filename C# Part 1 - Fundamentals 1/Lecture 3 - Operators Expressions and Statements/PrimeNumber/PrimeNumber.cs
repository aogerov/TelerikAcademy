using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number between 1 and 100: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? "The number is prime." : "The number is NOT prime.");
    }
}