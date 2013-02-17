using System;

class TwoInteger
{
    static void Main()
    {
        int five = 5;
        int ten = 10;

        ten = ten + five;
        five = ten - five;
        ten = ten - five;

        Console.WriteLine("Five -> {0}\nTen -> {1}", five, ten);
    }
}
