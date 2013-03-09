//Create a class Path to hold a sequence of points in the 3D space.

using System;
using System.Collections.Generic;

class Path
{
    private List<Point3D> pointsSequence = new List<Point3D>();

    public List<Point3D> PointsSequence
    {
        get
        {
            return this.pointsSequence;
        }
        set
        {
            this.pointsSequence = value;
        }
    }
}