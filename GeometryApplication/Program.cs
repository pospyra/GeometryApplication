using GeometryLibrary.Figures;
using GeometryLibrary.Interfaces;

namespace GeometryApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 5.0;
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;

            var circle = new Circle(radius);
            var triangle = new Triangle(side1, side2, side3);

            double circleArea = circle.CalculateArea();
            double triangleArea = triangle.CalculateArea();

            bool isRightTriangle = triangle.IsRightTriangle();

            Console.WriteLine($"Площадь круга с радиусом {radius} равна {circleArea}" );
            Console.WriteLine($"Площадь треугольника со сторонами {side1}, {side2} и {side3} равна {triangleArea}" );
            Console.WriteLine("Треугольник {0} прямоугольный", isRightTriangle ? "является" : "не является");

            Console.ReadLine();
        }
    }
}