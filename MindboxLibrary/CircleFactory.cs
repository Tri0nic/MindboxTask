namespace MindboxLibrary
{
    public class CircleFactory
    {
        public static Circle CreateFromRadius(double radius)
        {
            return new Circle(radius);
        }

        public static Circle CreateFromDiameter(double diameter)
        {
            return new Circle(diameter / 2);
        }

        public static Circle CreateFromPerimeter(double perimeter)
        {
            return new Circle(perimeter / (2 * Math.PI));
        }
    }
}
