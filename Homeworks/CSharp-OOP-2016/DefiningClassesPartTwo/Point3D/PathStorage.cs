////Problem 4. Path
////Create a static class PathStorage with static methods to save and load paths from a text file.
////Use a file format of your choice.

namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        private static string saveFilePath = @"..\..\TextFiles\SavedPaths.txt";
        private static string loadFilePath = @"..\..\TextFiles\LoadedPaths.txt";

        public static string SaveFilePath
        {
            get
            {
                return saveFilePath;
            }
        }

        public static string LoadFilePath
        {
            get
            {
                return loadFilePath;
            }
        }

        public static List<Path> LoadPathsFromFile()
        {
            var paths = new List<Path>();
            var pathReader = new StreamReader(LoadFilePath);
            using (pathReader)
            {
                int numberOfPaths = int.Parse(pathReader.ReadLine());
                for (int i = 0; i < numberOfPaths; i++)
                {
                    int numberOfPointsinPath = int.Parse(pathReader.ReadLine());
                    var path = new Path();
                    string[] currentLine;
                    for (int k = 0; k < numberOfPointsinPath; k++)
                    {
                        currentLine = pathReader.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        double x = double.Parse(currentLine[0]);
                        double y = double.Parse(currentLine[1]);
                        double z = double.Parse(currentLine[2]);
                        path.AddPoint(new Point3D(x, y, z));
                    }

                    paths.Add(path);
                }
            }

            return paths;
        }

        public static void SavePathsToFile(List<Path> paths)
        {
            var pathWriter = new StreamWriter(SaveFilePath);
            using (pathWriter)
            {
                ////number of paths
                pathWriter.WriteLine(paths.Count);
                foreach (var path in paths)
                {
                    ////number of point in the current path
                    pathWriter.WriteLine(path.PointsPath.Count);
                    foreach (var point3d in path.PointsPath)
                    {
                        ////x, y, z of the currnt point
                        pathWriter.WriteLine(point3d.X + ", " + point3d.Y + ", " + point3d.Z);
                    }
                }
            }
        }
    }
}
