namespace MindboxLibrary
{
    public class TriangleFactory
    {
        public static Triangle CreateFromSides(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        public static Triangle CreateRightAngledFromTwoSides(double a, double b)
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return new Triangle(a, b, c);
        }

        public static Triangle CreateEquilateralTriangle(double a)
        {
            return new Triangle(a, a, a);
        }

        public static Triangle CreateFromTwoSidesAndAngle(double a, double b, double angleDegrees)
        {
            double angleRadians = angleDegrees * (Math.PI / 180);
            
            double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleRadians));
            return new Triangle(a, b, c);
        }
    }
}
