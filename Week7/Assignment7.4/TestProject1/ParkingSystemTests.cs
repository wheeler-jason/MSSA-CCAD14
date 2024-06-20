using NUnit.Framework;
using Assignment7._4;

namespace Assignment7._4.Tests
{
    [TestFixture]
    public class ParkingSystemTests
    {
        [Test]
        public void AddCar_WhenBigSpotAvailable_ReturnsTrue()
        {
            // Arrange
            int big = 1;
            int medium = 0;
            int small = 0;
            ParkingSystem parkingSystem = new ParkingSystem(big, medium, small);

            // Act
            bool result = parkingSystem.AddCar(1);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddCar_WhenMediumSpotAvailable_ReturnsTrue()
        {
            // Arrange
            int big = 0;
            int medium = 1;
            int small = 0;
            ParkingSystem parkingSystem = new ParkingSystem(big, medium, small);

            // Act
            bool result = parkingSystem.AddCar(2);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddCar_WhenSmallSpotAvailable_ReturnsTrue()
        {
            // Arrange
            int big = 0;
            int medium = 0;
            int small = 1;
            ParkingSystem parkingSystem = new ParkingSystem(big, medium, small);

            // Act
            bool result = parkingSystem.AddCar(3);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void AddCar_WhenNoSpotAvailable_ReturnsFalse()
        {
            // Arrange
            int big = 0;
            int medium = 0;
            int small = 0;
            ParkingSystem parkingSystem = new ParkingSystem(big, medium, small);

            // Act
            bool result = parkingSystem.AddCar(1);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
