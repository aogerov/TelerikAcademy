//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index,
//inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.

//Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

//Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
//You may need to add a generic constraints for the type T.

using System;
using System.Text;
using System.Linq;

class GenericList<T>
{
    private T[] array;
    private int index;

    //default constructor
    public GenericList()
    {
        array = new T[4];
        index = 0;
    }

    //constructor with capacity
    public GenericList(int capacity)
    {
        array = new T[capacity];
        index = 0;
    }

    //get count
    public int Count
    {
        get
        {
            return index;
        }
    }

    //adding element
    public void Add(T value)
    {
        if (index == array.Length)
        {
            AutoGrow();
        }

        array[index] = value;
        index++;
    }

    //accessing element by index
    public T Index(int index)
    {
        if (index >= this.index)
        {
            throw new IndexOutOfRangeException();
        }

        return array[index];
    }

    //removing element by index
    public void RemoveAt(int index)
    {
        if (index >= this.index)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = index; i < this.index - 1; i++)
        {
            array[i] = array[i + 1];
        }

        this.index--;
    }

    //inserting element at given position
    public void Insert(int index, T item)
    {
        if (index > this.index)
        {
            throw new IndexOutOfRangeException();
        }

        for (int i = index; i <= this.index; i++)
        {
            if (i == this.index)
            {
                Add(item);
                break;
            }

            T switchItem = array[i];
            array[i] = item;
            item = switchItem;
        }
    }

    //clearing the list
    public void Clear()
    {
        array = new T[array.Length];
        index = 0;
    }

    //finding element by its value
    public int IdexOf(T value)
    {
        int indexOf = -1;

        for (int i = 0; i < index; i++)
        {
            if (array[i].Equals(value))
            {
                return i;
            }
        }

        return indexOf;
    }

    //ToString()
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("[ ");

        if (index == 0)
        {
            sb.Append("empty list");
        }

        for (int i = 0; i < index; i++)
        {
            sb.Append(array[i]);

            if (i < index - 1)
            {
                sb.Append(", ");
            }
        }

        sb.Append(" ]");

        return sb.ToString();
    }

    //auto-grow functionality
    private void AutoGrow()
    {
        T[] tempArray = (T[])array.Clone();

        array = new T[array.Length * 2];

        tempArray.CopyTo(array, 0);
    }

    //find minimal value
    public T Min()
    {
        if (index == 0)
        {
            throw new IndexOutOfRangeException("List is empty");
        }

        if (index == 1)
        {
            return array[0];
        }

        T min = array[0];

        if (min is IComparable<T>)
        {
            for (int i = 1; i < index; i++)
            {
                if ((min as IComparable<T>).CompareTo(array[i]) > 0)
                {
                    min = array[i];
                }
            }

            return min;
        }
        else
        {
            throw new ArgumentException("List items can't be compared!");
        }
    }

    //find maximal value
    public T Max()
    {
        if (index == 0)
        {
            throw new IndexOutOfRangeException("List is empty");
        }

        if (index == 1)
        {
            return array[0];
        }

        T max = array[0];

        if (max is IComparable<T>)
        {
            for (int i = 1; i < index; i++)
            {
                if ((max as IComparable<T>).CompareTo(array[i]) < 0)
                {
                    max = array[i];
                }
            }

            return max;
        }
        else
        {
            throw new ArgumentException("List items can't be compared!");
        }
    }
}