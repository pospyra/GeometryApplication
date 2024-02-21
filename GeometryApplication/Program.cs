using GeometryLibrary.Figures;

namespace GeometryApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Цикл для повторного запуска программы
            {
                PrintMenu();
                int choice = GetChoice();
                switch (choice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateTriangleArea();
                        break;
                    case 3:
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, выберите опцию от 1 до 3:");
                        break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Выберите фигуру для вычисления площади:");
            Console.WriteLine("1. Круг");
            Console.WriteLine("2. Треугольник");
            Console.WriteLine("3. Выйти");
        }

        static int GetChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, выберите опцию от 1 до 3:");
            }
            return choice;
        }

        static void CalculateCircleArea()
        {
            Console.Write("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            double area = circle.CalculateArea();
            Console.WriteLine($"Площадь круга равна {area}");
        }

        static void CalculateTriangleArea()
        {
            Console.Write("Введите длины сторон треугольника (через пробел): ");
            string[] sides = Console.ReadLine().Split(' ');
            double side1 = double.Parse(sides[0]);
            double side2 = double.Parse(sides[1]);
            double side3 = double.Parse(sides[2]);
            Triangle triangle = new Triangle(side1, side2, side3);
            double area = triangle.CalculateArea();
            Console.WriteLine($"Площадь треугольника равна {area}");

            if (triangle.IsRightTriangle())
            {
                Console.WriteLine("Треугольник является прямоугольным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным.");
            }
        }

    }
}
