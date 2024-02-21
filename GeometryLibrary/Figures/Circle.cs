using GeometryLibrary.Figures.Base;

namespace GeometryLibrary.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга должен быть положительным числом.");
            }

            Radius = radius;
        }

        public override double CalculateArea()
        {
            var area = Math.PI * Radius * Radius;
            return Math.Round(area, 3);
        }
    }
}
