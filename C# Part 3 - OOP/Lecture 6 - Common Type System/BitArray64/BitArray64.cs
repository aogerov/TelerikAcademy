//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections;
using System.Collections.Generic;

class BitArray64 : IEnumerable<int>
{
    public ulong Number { get; set; }

    public BitArray64(ulong number = 0)
    {
        this.Number = number;
    }

    public IEnumerator<int> GetEnumerator()
    {
        int[] bits = GetBits();

        for (int i = 0; i < bits.Length; i++)
        {
            yield return bits[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private int[] GetBits()
    {
        ulong tempNumber = Number;

        int[] bits = new int[64];

        for (int i = 0; i < bits.Length; i++)
        {
            if (tempNumber % 2 == 1)
            {
                bits[bits.Length - 1 - i] = 1;
            }

            tempNumber = tempNumber / 2;

            if (tempNumber == 0)
            {
                break;
            }
        }

        return bits;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        var number = obj as BitArray64;

        if (this.Number == number.Number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return 12 * Number.GetHashCode();
        }
    }

    public int this[int index]
    {
        get
        {
            int[] bits = GetBits();

            return bits[bits.Length - 1 - index];
        }
    }

    public static bool operator ==(BitArray64 number1, BitArray64 number2)
    {
        return number1.Equals(number2);
    }

    public static bool operator !=(BitArray64 number1, BitArray64 number2)
    {
        return !(number1.Equals(number2));
    }
}