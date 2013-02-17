//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        //setting bool array with true values
        System.Collections.BitArray primeNumbers = new System.Collections.BitArray(10000001, true);

        //switching the numbers which are not prime to false
        for (int primeNumberIndex = 2; primeNumberIndex <= primeNumbers.Length / 2; primeNumberIndex++)
        {
            if (primeNumbers[primeNumberIndex])
            {
                for (int index = primeNumberIndex * 2; index < primeNumbers.Length; index += primeNumberIndex)
                {
                    if (!primeNumbers[index])
                    {
                        continue;
                    }
                    if (index % primeNumberIndex == 0)
                    {
                        primeNumbers[index] = false;
                    }
                }
            }
        }

        //printing all prime numbers from 1 to 10000000
        for (int index = 2; index < primeNumbers.Length; index++ )
        {
            if (primeNumbers[index] == true)
            {
                Console.WriteLine(index);
            }
        }
    }
}