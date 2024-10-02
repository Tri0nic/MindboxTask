using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxLibrary.Circle.Tests
{
    [TestClass]
    public class CircleFactoryTests
    {
        private ICircleFactory _circleFactory;

        [TestInitialize]
        public void Setup()
        {
            _circleFactory = new CircleFactory();
        }

        [TestMethod]
        public void CreateCircleFromRadius_ShouldReturnCircle_WithCorrectRadius()
        {
            // Arrange
            double radius = 10.0;

            // Act
            Circle circle = _circleFactory.CreateCircleFromRadius(radius);

            // Assert
            Assert.AreEqual(radius, circle.Radius);
        }

        [TestMethod]
        public void CreateCircleFromDiameter_ShouldReturnCircle_WithHalfOfDiameterAsRadius()
        {
            // Arrange
            double diameter = 10.0;

            // Act
            Circle circle = _circleFactory.CreateCircleFromDiameter(diameter);

            // Assert
            double expectedRadius = diameter / 2;
            Assert.AreEqual(expectedRadius, circle.Radius);
        }

        [TestMethod]
        public void CreateCircleFromPerimeter_ShouldReturnCircle_WithCorrectRadius()
        {
            // Arrange
            double perimeter = 31.4159265359;

            // Act
            Circle circle = _circleFactory.CreateCircleFromPerimeter(perimeter);

            // Assert
            double expectedRadius = perimeter / (2 * Math.PI);
            Assert.AreEqual(expectedRadius, circle.Radius, 1e-5);
        }

        [TestMethod]
        public void CreateCircleFromRadius_ShouldThrowArgumentException_WhenRadiusIsZeroOrNegative()
        {
            // Arrange
            double invalidRadius = 0.0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _circleFactory.CreateCircleFromRadius(invalidRadius), "Радиус должен быть больше нуля!");

            invalidRadius = -5.0;
            Assert.ThrowsException<ArgumentException>(() => _circleFactory.CreateCircleFromRadius(invalidRadius), "Радиус должен быть больше нуля!");
        }
    }
}