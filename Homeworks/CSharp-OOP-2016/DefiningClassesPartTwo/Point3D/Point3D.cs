////Problem 1. Structure
////Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
////Implement the ToString() to enable printing a 3D point.

namespace Point3D
{
    public struct Point3D
    {
        private static readonly Point3D O;

        static Point3D()
        {
            O = new Point3D(0, 0, 0);
        }

        public Point3D(double xcoordinate, double ycoordinate, double zcoordinate)
            : this()
        {
            this.X = xcoordinate;
            this.Y = ycoordinate;
            this.Z = zcoordinate;
        }

        ////Problem 2. Static read-only field
        ////Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        ////Add a static property to return the point O.

        public static Point3D StartPoint
        {
            get { return O; }
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public override string ToString()
        {
            return $"x = {this.X}, y = {this.Y}, z = {this.Z}";
        }
    }
}
