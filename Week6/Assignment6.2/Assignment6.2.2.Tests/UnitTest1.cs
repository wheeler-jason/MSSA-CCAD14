using NUnit.Framework;
using Assignment6._2._2;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void ProductExceptSelf_WhenInputIsValid()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int[] expected = { 24, 12, 8, 6 };

            // Act
            int[] result = Program.ProductExceptSelf(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_WhenInputContainsNegativeNumbers()
        {
            // Arrange
            int[] nums = { -1, 1, 0, -3, 3 };
            int[] expected = { 0, 0, 9, 0, 0 };

            // Act
            int[] result = Program.ProductExceptSelf(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_WhenInputIsEmpty()
        {
            // Arrange
            int[] nums = { };
            int[] expected = { };

            // Act
            int[] result = Program.ProductExceptSelf(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ProductExceptSelf_WhenInputContainsSingleElement()
        {
            // Arrange
            int[] nums = { 5 };
            int[] expected = { 1 };

            // Act
            int[] result = Program.ProductExceptSelf(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}