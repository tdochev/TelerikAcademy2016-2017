namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        { 
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }

        public override string ToString()
        {
            return "Rectangle" + base.ToString();
        }
    }
}
