using System;

class SequenceMembers
{
    static void Main()
    {
        int startNumber = 2;
        int length = 10;

        for (int i = startNumber; i < startNumber + length; i++)
        {
            if (i % 2 == 0)
            {
                if (i == startNumber + length - 1)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
            else
            {
                if (i == startNumber + length - 1)
                {
                    Console.WriteLine(i * -1);
                    break;
                }
                else
                {
                    Console.Write((i * -1) + ", ");
                }
            }
        }
    }
}