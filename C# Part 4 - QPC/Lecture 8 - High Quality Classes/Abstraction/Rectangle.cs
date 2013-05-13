using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double Width { get; set; }

        private double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if (width < 0)
            {
                throw new ArgumentException("Width can't be negative.");
            }

            if (height < 0)
            {
                throw new ArgumentException("Height can't be negative.");
            }

            this.Width = width;
            this.Height = height;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
