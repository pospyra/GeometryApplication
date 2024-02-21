using GeometryLibrary.Figures.Base;

namespace GeometryLibrary.Figures
{
    public class Triangle : Figure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public bool IsRightTriangle()
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }

        public override double CalculateArea()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            var area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            return Math.Round(area, 3);
        }
    }
}