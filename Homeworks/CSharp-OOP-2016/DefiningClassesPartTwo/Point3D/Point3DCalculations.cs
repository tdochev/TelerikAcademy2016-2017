////Problem 3. Static class
////Write a static class with a static method to calculate the distance between two points in the 3D space.
namespace Point3D
{
    using System;

    public static class Point3DCalculations
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double xdistance = (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X);
            double ydistance = (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y);
            double zdistance = (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z);
            return Math.Sqrt(xdistance + ydistance + zdistance);
        }
    }
}
