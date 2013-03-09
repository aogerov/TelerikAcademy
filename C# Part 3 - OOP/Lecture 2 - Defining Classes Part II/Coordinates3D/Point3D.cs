//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.

using System;

struct Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double pointX, double pointY, double pointZ)
        : this()
    {
        this.X = pointX;
        this.Y = pointY;
        this.Z = pointZ;
    }

    public override string ToString()
    {
        return String.Format("X: {0}, Y: {1}, Z: {2}", X, Y, Z);
    }

    private static readonly Point3D coordinateSystemStart = new Point3D(0, 0, 0);

    public static Point3D CoordinateSystemStart
    {
        get
        {
            return coordinateSystemStart;
        }
    }
}