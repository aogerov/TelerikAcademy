//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class IndexMultiply
{
    static void Main()
    {
        int[] array = new int[20];

        //array initialization & multiply
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = index * 5;
        }

        //printing on the console
        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine(array[index]);
        }
    }
}