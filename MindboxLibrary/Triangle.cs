namespace MindboxLibrary
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Стороны не образуют треугольник!");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[1], 2) - Math.Pow(sides[0], 2)) < 0.0001;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
