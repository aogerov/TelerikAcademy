using System;

namespace CohesionAndCoupling
{
    public static class Dimension
    {
        public static double CalcVolume(int width, int height, int depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalcDiagonal3D(int width, int height, int depth)
        {
            double distance = Distance.Calc3D(0, 0, 0, width, height, depth);
            return distance;
        }

        public static double CalcDiagonal2D(int width, int height)
        {
            double distance = Distance.Calc2D(0, 0, width, height);
            return distance;
        }
    }
}
