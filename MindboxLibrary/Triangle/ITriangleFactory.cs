namespace MindboxLibrary.Triangle
{
    public interface ITriangleFactory
    {
        public Triangle CreateTriangleFromSides(double sideA, double sideB, double sideC);
        public Triangle CreateTriangleRightAngledFromTwoSides(double sideA, double sideB);
        public Triangle CreateTriangleEquilateralTriangle(double sideA);
        public Triangle CreateTriangleFromTwoSidesAndAngle(double sideA, double sideB, double angleDegrees);
    }
}