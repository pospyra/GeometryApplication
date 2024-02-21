using GeometryLibrary.Figures;
using NUnit.Framework;

namespace Tests
{
    public class GeometryCalculatorTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            double radius = 5.0;
            double expectedArea = Math.PI * radius * radius;

            var circle = new Circle(radius);
            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            double p = (side1 + side2 + side3) / 2;
            double expectedArea = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

            var triangle = new Triangle(side1, side2, side3);
            double actualArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void RightTriangleDetection()
        {
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;

            var triangle = new Triangle(side1, side2, side3);
            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.IsTrue(isRightTriangle);
        }
    }
}