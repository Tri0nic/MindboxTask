using Microsoft.Extensions.DependencyInjection;
using MindboxLibrary;
using MindboxLibrary.Circle;
using MindboxLibrary.Triangle;
using MindboxTask;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddShapeFactories()
            .BuildServiceProvider();

        var circleFactory = serviceProvider.GetService<ICircleFactory>();
        var triangleFactory = serviceProvider.GetService<ITriangleFactory>();

        if (circleFactory == null )
            throw new InvalidOperationException("Не удалось получить ICircleFactory из DI контейнера.");
        if (triangleFactory == null)
            throw new InvalidOperationException("Не удалось получить ITriangleFactory из DI контейнера.");


        List<IShape> shapes = new List<IShape>()
        {
            circleFactory.CreateCircleFromRadius(10),
            triangleFactory.CreateTriangleEquilateralTriangle(15),
            circleFactory.CreateCircleFromDiameter(100),
            triangleFactory.CreateTriangleFromSides(3, 4, 5),
            triangleFactory.CreateTriangleFromTwoSidesAndAngle(3, 4, 90)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Площадь фигуры равна {shape.CalculateArea()}");
        }

        Console.WriteLine($"Прямоугольный ли треугольник? --- {((Triangle)shapes[1]).IsRightAngled()}");
        Console.WriteLine($"Прямоугольный ли треугольник? --- {((Triangle)shapes[3]).IsRightAngled()}");
    }
}