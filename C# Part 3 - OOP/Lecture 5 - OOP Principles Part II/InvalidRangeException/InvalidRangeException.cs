using System;

class InvalidRangeException<T> : ApplicationException
{
    public T Start { get; private set; }
    public T End { get; private set; }
    
    public InvalidRangeException(T start, T end, string message, Exception ex = null)
        : base(message, ex) 
    {
        this.Start = start;
        this.End = end;
    }
}