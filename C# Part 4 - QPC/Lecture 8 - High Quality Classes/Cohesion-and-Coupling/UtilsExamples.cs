using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileName.GetExtension("example"));
            Console.WriteLine(FileName.GetExtension("example.pdf"));
            Console.WriteLine(FileName.GetExtension("example.new.pdf"));

            Console.WriteLine(FileName.GetWithoutExtension("example"));
            Console.WriteLine(FileName.GetWithoutExtension("example.pdf"));
            Console.WriteLine(FileName.GetWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Distance.Calc2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Distance.Calc3D(5, 2, -1, 3, -6, 4));

            int width = 3;
            int height = 4;
            int depth = 5;

            double volume = Dimension.CalcVolume(width, height, depth);
            Console.WriteLine("Volume = {0:f2}", volume);

            double diagonalXYZ = Dimension.CalcDiagonal3D(width, height, depth);
            Console.WriteLine("Diagonal XYZ = {0:f2}", diagonalXYZ);

            double diagonalXY = Dimension.CalcDiagonal2D(width, height);
            Console.WriteLine("Diagonal XY = {0:f2}", diagonalXY);

            double diagonalXZ = Dimension.CalcDiagonal2D(width, depth);
            Console.WriteLine("Diagonal XZ = {0:f2}", diagonalXZ);

            double diagonalYZ = Dimension.CalcDiagonal2D(height, depth);
            Console.WriteLine("Diagonal YZ = {0:f2}", diagonalYZ);
        }
    }
}
