//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class DecHexPercSci
{
    static void Main()
    {
        Console.WriteLine("Enter some number: ");
        //int number = int.Parse(Console.ReadLine());
        int number = 31;

        Console.WriteLine("Decimal: {0}", number);
        Console.WriteLine("Hexaecimal: {0:X}", number);
        Console.WriteLine("Percentage: {0:P}", (double)number / 100);
        Console.WriteLine("Scientific notation: {0:E}", number);
    }
}