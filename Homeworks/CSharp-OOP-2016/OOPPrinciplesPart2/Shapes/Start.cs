namespace Shapes
{
    using System;

    using Shapes.Models;

    public class Start
    {
        public static void Main()
        {
            var shapes = new Shape[] 
            {
                new Rectangle(3, 4),
                new Rectangle(4.5, 3.4),
                new Triangle(2.5, 19.2),
                new Triangle(12.5, 11.4),
                new Square(4),
                new Square(12)
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
