using System;

class Circle : Shape
{
    public Circle(double width) 
        : base(width, 0) { } 

    public override double CalculateSurface()
    {
        return (Math.PI * this.Width * this.Width);
    }
}