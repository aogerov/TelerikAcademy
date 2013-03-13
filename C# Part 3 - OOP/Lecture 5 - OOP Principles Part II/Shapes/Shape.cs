using System;

abstract class Shape
{
    public double Width { get; protected set; }
    public double Height { get; protected set; }

    protected Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public abstract double CalculateSurface();
}