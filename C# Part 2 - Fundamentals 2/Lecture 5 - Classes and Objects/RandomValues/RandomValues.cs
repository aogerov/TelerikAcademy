//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomValues
{
    static void Main()
    {
        int value;
        Random random = new Random();

        for (int counter = 1; counter <= 10; counter++)
        {
            value = random.Next(100, 200);
            Console.WriteLine("{0} -> {1}", counter, value);
        }
    }
}