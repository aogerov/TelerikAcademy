using System;

class BitArray64Program
{
    static void Main()
    {
        BitArray64 number = new BitArray64();
        
        number.Number = 5;

        Console.WriteLine("Number {0} in 2 bit base:", number.Number);
        foreach (var digit in number)
        {
            Console.Write(digit);
        }
        
        Console.WriteLine();

        Console.WriteLine("Index 2 of 5 -> {0}", number[2]);

        BitArray64 number2 = new BitArray64(5);

        Console.WriteLine("{0} == {1} - > {2}", number.Number, number2.Number, number == number2);
        Console.WriteLine("{0} != {1} - > {2}", number.Number, number2.Number, number != number2);

        number2.Number = 7;

        Console.WriteLine("{0} == {1} - > {2}", number.Number, number2.Number, number == number2);
        Console.WriteLine("{0} != {1} - > {2}", number.Number, number2.Number, number != number2);
    }
}