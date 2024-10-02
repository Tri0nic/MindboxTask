using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxLibrary.Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_Constructor_ShouldThrowArgumentException_WhenSidesDoNotFormTriangle()
        {
            // Arrange
            double sideA = 1.0, sideB = 2.0, sideC = 10.0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC), "Стороны не образуют треугольник!");
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
        public void IsRightAngled_ShouldReturnTrue_ForRightAngledTriangle()
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
        public void IsRightAngled_ShouldReturnFalse_ForNonRightAngledTriangle()
        {
            // Arrange
            double sideA = 2.0, sideB = 3.0, sideC = 4.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }
    }
}