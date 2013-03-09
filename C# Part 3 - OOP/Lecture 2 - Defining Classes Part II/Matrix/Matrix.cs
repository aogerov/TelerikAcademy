//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

//Implement an indexer this[row, col] to access the inner matrix cells.

//Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

using System;
using System.Text;

class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    private T[,] matrix;

    private int Row
    {
        get
        {
            return matrix.GetLength(0);
        }
    }

    private int Col
    {
        get
        {
            return matrix.GetLength(1);
        }
    }

    public Matrix(int row, int col)
    {
        matrix = new T[row, col];
    }

    public Matrix(T[,] values)
    {
        matrix = values;
    }

    public T this[int row, int col]
    {
        get
        {
            return matrix[row, col];
        }
        set
        {
            matrix[row, col] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
    {
        if ((first.Row == second.Row) && (first.Col == second.Col))
        {
            Matrix<T> result = new Matrix<T>(first.Row, first.Col);

            for (int row = 0; row < first.Row; row++)
            {
                for (int col = 0; col < first.Col; col++)
                {
                    result[row, col] = (dynamic)first[row, col] + (dynamic)second[row, col];
                }
            }

            return result;
        }
        else
        {
            throw new ArgumentException("Array dimensions mismatch!");
        }
    }

    public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
    {
        if ((first.Row == second.Row) && (first.Col == second.Col))
        {
            Matrix<T> result = new Matrix<T>(first.Row, first.Col);

            for (int row = 0; row < first.Row; row++)
            {
                for (int col = 0; col < first.Col; col++)
                {
                    result[row, col] = (dynamic)first[row, col] - (dynamic)second[row, col];
                }
            }

            return result;
        }
        else
        {
            throw new ArgumentException("Array dimensions mismatch!");
        }
    }

    public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
    {
        if ((first.Row == second.Row) && (first.Col == second.Col))
        {
            Matrix<T> result = new Matrix<T>(first.Row, first.Col);

            for (int row = 0; row < first.Row; row++)
            {
                for (int col = 0; col < first.Col; col++)
                {
                    result[row, col] = (dynamic)first[row, col] * (dynamic)second[row, col];
                }
            }

            return result;
        }
        else
        {
            throw new ArgumentException("Array dimensions mismatch!");
        }
    }

    public static bool operator true(Matrix<T> matrix)
    {
        if ((matrix.Row > 0) && (matrix.Col > 0))
        {
            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        else
        {
            throw new ArgumentException("No elements exeption!");
        }
    }

    public static bool operator false(Matrix<T> matrix)
    {
        if ((matrix.Row > 0) && (matrix.Col > 0))
        {
            for (int row = 0; row < matrix.Row; row++)
            {
                for (int col = 0; col < matrix.Col; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        else
        {
            throw new ArgumentException("No elements exeption!");
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int row = 0; row < Row; row++)
        {
            sb.Append("[ ");

            for (int col = 0; col < Col; col++)
            {
                sb.Append(matrix[row, col]);

                if (col < Col - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append(" ]");

            if (row < Row- 1)
            {
                sb.Append("\r\n");
            }
        }

        return sb.ToString();
    }
}