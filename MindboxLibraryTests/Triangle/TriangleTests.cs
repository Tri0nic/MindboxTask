using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxLibrary.Triangle.Tests
{
    [TestClass]
    public class TriangleTests
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
            Assert.AreEqual(sideA, triangle.SideA);
            Assert.AreEqual(sideB, triangle.SideB);
            Assert.AreEqual(sideC, triangle.SideC);
        }

        [TestMethod]
        public void CalculateArea_ValidTriangle_ShouldReturnCorrectArea()
        {
            // Arrange
            double sideA = 3.0, sideB = 4.0, sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            double expectedArea = 6.0;
            Assert.AreEqual(expectedArea, area, 1e-5);
        }

        [TestMethod]
        public void IsRightAngled_ValidTriangle_ShouldReturnTrue()
        {
            // Arrange
            double sideA = 3.0, sideB = 4.0, sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled);
        }

        [TestMethod]
        public void IsRightAngled_NonRightAngledTriangle_ShouldReturnFalse()
        {
            // Arrange
            double sideA = 2.0, sideB = 3.0, sideC = 4.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }

        [TestMethod]
        public void InvalidTriangle_ShouldThrowArgumentException()
        {
            // Arrange
            double sideA = 1.0, sideB = 2.0, sideC = 10.0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}
