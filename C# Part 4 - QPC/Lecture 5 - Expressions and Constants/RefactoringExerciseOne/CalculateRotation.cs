using System;

class CalculateRotation
{
    public class Size
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }

    public static Size GetRotatedSize(Size size, double angleOfFigureForRotation)
    {
        double widthCos = Math.Abs(Math.Cos(angleOfFigureForRotation)) * size.Width;
        double heightSin = Math.Abs(Math.Sin(angleOfFigureForRotation)) * size.Height;
        double width = widthCos + heightSin;
        
        double widthSin = Math.Abs(Math.Sin(angleOfFigureForRotation)) * size.Width;
        double heightCos = Math.Abs(Math.Cos(angleOfFigureForRotation)) * size.Height;
        double height = widthSin + heightCos;

        return new Size(width, height);
    }
}