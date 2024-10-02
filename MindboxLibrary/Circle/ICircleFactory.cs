namespace MindboxLibrary.Circle
{
    public interface ICircleFactory
    {
        public Circle CreateCircleFromRadius(double radius);
        public Circle CreateCircleFromDiameter(double diameter);
        public Circle CreateCircleFromPerimeter(double perimeter);
    }
}