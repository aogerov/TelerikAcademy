﻿using System;

class NotByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}