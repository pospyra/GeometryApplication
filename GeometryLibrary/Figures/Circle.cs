using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Figures
{

    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}