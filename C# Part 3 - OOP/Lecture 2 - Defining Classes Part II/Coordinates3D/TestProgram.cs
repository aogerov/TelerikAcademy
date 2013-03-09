using System;
using System.Linq;

public class TestProgram
{
    public static void Main()
    {
        Path path = new Path();

        path.PointsSequence.Add(Point3D.CoordinateSystemStart);
        path.PointsSequence.Add(new Point3D(1.2, 2.4, 3.3));
        path.PointsSequence.Add(new Point3D(2.6, 4.3, 9.4));
        path.PointsSequence.Add(new Point3D(3.8, 8.7, 7.8));

        Console.WriteLine("Original path:");

        foreach (var item in path.PointsSequence)
        {
            Console.WriteLine(item.X + " " + item.Y + " " + item.Z);
        }

        PathStorage.SavePath(path, "..\\..\\database.txt");

        Path newPath = PathStorage.LoadPath("..\\..\\database.txt");

        Console.WriteLine("\r\nReaded path:");

        foreach (var item in newPath.PointsSequence)
        {
            Console.WriteLine(item.X + " " + item.Y + " " + item.Z);
        }

        newPath.PointsSequence.Add(new Point3D(4.3, 5.7, 6.2));
        newPath.PointsSequence.Add(new Point3D(5.8, 6.1, 9.9));

        Console.WriteLine("\r\nAdded 2 points in path:");

        foreach (var item in newPath.PointsSequence)
        {
            Console.WriteLine(item.X + " " + item.Y + " " + item.Z);
        }

        Console.WriteLine("\r\nDistance between points in path:");

        for (int i = 1; i < newPath.PointsSequence.Count; i++)
        {
            Console.WriteLine(CalculateDistance.Calculator(
                newPath.PointsSequence.ElementAt(i - 1), newPath.PointsSequence.ElementAt(i)));
        }
    }
}