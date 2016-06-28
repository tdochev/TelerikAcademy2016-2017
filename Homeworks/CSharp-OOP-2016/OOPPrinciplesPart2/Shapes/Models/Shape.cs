////Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
namespace Shapes.Models
{
    public abstract class Shape
    {
        private double width;

        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
                
        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format(", widhh = {0}, height = {1}, surface = {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}