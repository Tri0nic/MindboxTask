using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxLibrary.Circle.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Constructor_ShouldThrowArgumentException_WhenRadiusIsZeroOrNegative()
        {
            // Arrange
            double invalidRadius = 0.0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(invalidRadius), "Радиус должен быть больше нуля!");

            invalidRadius = -5.0;
            Assert.ThrowsException<ArgumentException>(() => new Circle(invalidRadius), "Радиус должен быть больше нуля!");
        }

        [TestMethod]
        public void CalculateArea_ShouldReturnCorrectArea_WhenRadiusIsValid()
        {
            // Arrange
            double radius = 5.0;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.AreEqual(expectedArea, area, 1e-5);
        }
    }
}