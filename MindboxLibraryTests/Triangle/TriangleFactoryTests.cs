using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxLibrary.Triangle.Tests
{
    [TestClass]
    public class TriangleFactoryTests
    {
        private ITriangleFactory _triangleFactory;

        [TestInitialize]
        public void Setup()
        {
            _triangleFactory = new TriangleFactory();
        }

        [TestMethod]
        public void CreateTriangleFromSides_ShouldReturnTriangle_WithCorrectSides()
        {
            // Arrange
            double sideA = 3.0, sideB = 4.0, sideC = 5.0;

            // Act
            Triangle triangle = _triangleFactory.CreateTriangleFromSides(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(sideA, triangle.GetType().GetField("_sideA", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
            Assert.AreEqual(sideB, triangle.GetType().GetField("_sideB", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
            Assert.AreEqual(sideC, triangle.GetType().GetField("_sideC", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
        }

        [TestMethod]
        public void CreateTriangleRightAngledFromTwoSides_ShouldReturnRightAngledTriangle()
        {
            // Arrange
            double sideA = 3.0, sideB = 4.0;

            // Act
            Triangle triangle = _triangleFactory.CreateTriangleRightAngledFromTwoSides(sideA, sideB);

            // Assert
            double expectedSideC = 5.0;
            Assert.AreEqual(expectedSideC, triangle.GetType().GetField("_sideC", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void CreateTriangleEquilateralTriangle_ShouldReturnTriangle_WithEqualSides()
        {
            // Arrange
            double sideA = 5.0;

            // Act
            Triangle triangle = _triangleFactory.CreateTriangleEquilateralTriangle(sideA);

            // Assert
            Assert.AreEqual(sideA, triangle.GetType().GetField("_sideA", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
            Assert.AreEqual(sideA, triangle.GetType().GetField("_sideB", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
            Assert.AreEqual(sideA, triangle.GetType().GetField("_sideC", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
        }

        [TestMethod]
        public void CreateTriangleFromTwoSidesAndAngle_ShouldReturnCorrectTriangle()
        {
            // Arrange
            double sideA = 3.0, sideB = 4.0, angleDegrees = 90.0;

            // Act
            Triangle triangle = _triangleFactory.CreateTriangleFromTwoSidesAndAngle(sideA, sideB, angleDegrees);

            // Assert
            double expectedSideC = 5.0;
            Assert.AreEqual(expectedSideC, triangle.GetType().GetField("_sideC", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(triangle));
        }

        [TestMethod]
        public void CreateTriangleFromSides_ShouldThrowArgumentException_WhenSidesDoNotFormTriangle()
        {
            // Arrange
            double sideA = 1.0, sideB = 2.0, sideC = 10.0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _triangleFactory.CreateTriangleFromSides(sideA, sideB, sideC), "Стороны не образуют треугольник!");
        }
    }
}