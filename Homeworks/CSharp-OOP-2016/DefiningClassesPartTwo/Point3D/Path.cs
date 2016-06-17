////Problem 4. Path
////Create a class Path to hold a sequence of points in the 3D space.

namespace Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pointsPath;

        public Path()
        {
            this.pointsPath = new List<Point3D>();
        }

        public List<Point3D> PointsPath
        {
            get { return new List<Point3D>(this.pointsPath); }
        }

        public void AddPoint(Point3D somePoint)
        {
            this.pointsPath.Add(somePoint);
        }
    }
}
