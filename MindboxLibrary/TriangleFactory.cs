namespace MindboxLibrary
{
    public class TriangleFactory
    {
        public static Triangle CreateFromSides(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

        public static Triangle CreateRightAngledFromTwoSides(double sideA, double sideB)
        {
            double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return new Triangle(sideA, sideB, sideC);
        }

        public static Triangle CreateEquilateralTriangle(double sideA)
        {
            return new Triangle(sideA, sideA, sideA);
        }

        public static Triangle CreateFromTwoSidesAndAngle(double sideA, double sideB, double angleDegrees)
        {
            double angleRadians = angleDegrees * (Math.PI / 180);
            
            double sideC = Math.Sqrt(sideA * sideA + sideB * sideB - 2 * sideA * sideB * Math.Cos(angleRadians));
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
