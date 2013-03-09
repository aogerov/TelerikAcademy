using System;

class TestProgram
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>();

        list.Add(0);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(7);
        list.Add(18);

        Console.WriteLine("Print list:\r\n{0}", list);
        Console.WriteLine("---------");

        Console.WriteLine("18 is at index: {0}", list.IdexOf(18));
        Console.WriteLine("---------");

        list.Clear();
        Console.WriteLine("Print list after Clear():\r\n{0}", list);
        Console.WriteLine("---------");

        list.Add(0);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(3);
        list.Add(8);

        Console.WriteLine("Print list:\r\n{0}", list);
        Console.WriteLine("---------");

        list.Insert(6, 13);
        Console.WriteLine("Print list after Insert(6, 13):\r\n{0}", list);
        Console.WriteLine("---------");

        list.RemoveAt(8);
        Console.WriteLine("Print list after RemoveAt(8):\r\n{0}", list);
        Console.WriteLine("---------");

        Console.WriteLine("At position 7: {0}", list.Index(7));
        Console.WriteLine("---------");

        Console.WriteLine("Min: {0}", list.Min());
        Console.WriteLine("Max: {0}", list.Max());
        Console.WriteLine("---------");
    }
}