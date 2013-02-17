using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Integer with null value -> " + nullInt.GetValueOrDefault());
        Console.WriteLine("Double with null value -> " + nullDouble.GetValueOrDefault());
        nullInt = 2;
        nullDouble = 4.23;
        Console.WriteLine("Integer with added value -> " + nullInt.GetValueOrDefault());
        Console.WriteLine("Double with added value -> " + nullDouble.GetValueOrDefault());
    }
}