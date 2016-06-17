namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Start
    {
        public static void Main()
        {
            var firstPoint = new Point3D(1, 2, 3);
            var secondPoint = new Point3D(2, 3, 4);
            var thirdPoint = new Point3D(3, 4, 5);
            var forthPoint = new Point3D(4, 5, 6);
            Console.WriteLine("Created 4 test point and printing them on the console:");
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
            Console.WriteLine(thirdPoint);
            Console.WriteLine(forthPoint);
            Console.WriteLine("\nPrintitng start point:");
            Console.WriteLine(Point3D.StartPoint);
            Console.WriteLine("\nCalculating the distance between the two points:");
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
            Console.WriteLine("Distance: " + Point3DCalculations.CalculateDistance(firstPoint, secondPoint));
            var firstPath = new Path();
            firstPath.AddPoint(firstPoint);
            firstPath.AddPoint(secondPoint);
            var secondPath = new Path();
            secondPath.AddPoint(thirdPoint);
            secondPath.AddPoint(forthPoint);
            var paths = new List<Path>();
            paths.Add(firstPath);
            paths.Add(secondPath);
            PathStorage.SavePathsToFile(paths);
            Console.WriteLine("\nSucssesfuly saved paths to the following file:\n " + System.IO.Path.GetFullPath(PathStorage.SaveFilePath));
            var pathsLoadedFromFile = PathStorage.LoadPathsFromFile();
            Console.WriteLine("\nPrinting the points read from the paths saved in the following file:\n " + System.IO.Path.GetFullPath(PathStorage.LoadFilePath));
            foreach (var path in pathsLoadedFromFile)
            {
                foreach (var point3d in path.PointsPath)
                {
                    Console.WriteLine(point3d.ToString());
                }
            }
        }
    }
}
