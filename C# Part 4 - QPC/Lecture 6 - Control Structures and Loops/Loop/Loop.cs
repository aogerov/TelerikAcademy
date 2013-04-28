using System;

public class Loop
{
    public void LoopTest(int[] array, int expectedValue)
    {
        bool fondValue = false;

        for (int i = 0; i < 100; )
        {
            Console.WriteLine(array[i]);

            if (i % 10 == 0)
            {
                if (array[i] == expectedValue)
                {
                    fondValue = true;
                    break;
                }
            }

            i++;
        }

        if (fondValue)
        {
            Console.WriteLine("Value Found");
        }

    }
}