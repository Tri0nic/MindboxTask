namespace MindboxLibrary.Circle
{
    public class CircleFactory : ICircleFactory
    {
        public Circle CreateCircleFromRadius(double radius)
        {
            return new Circle(radius);
        }

        public Circle CreateCircleFromDiameter(double diameter)
        {
            return new Circle(diameter / 2);
        }

        public Circle CreateCircleFromPerimeter(double perimeter)
        {
            return new Circle(perimeter / (2 * Math.PI));
        }
    }
}
