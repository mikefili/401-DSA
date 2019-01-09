using System;
using Xunit;
using ArrayShift;

namespace UnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void CanTakeEvenArray()
        {
            // Arrange
            int[] test = { 2, 4, 6, 8 };
            int value = 5;
            int[] expected = { 2, 4, 5, 6, 8 };
            // Act
            // Assert
            Assert.Equal(expected, Program.ArrayShift(test, value));
        }

        [Fact]
        public void CanTakeOddArray()
        {
            // Arrange
            int[] test = { 2, 4, 6 };
            int value = 5;
            int[] expected = { 2, 4, 5, 6 };
            // Act
            // Assert
            Assert.Equal(expected, Program.ArrayShift(test, value));
        }

        [Fact]
        public void CanTakeSingleValueArray()
        {
            // Arrange
            int[] test = { 2 };
            int value = 5;
            int[] expected = { 2, 5 };
            // Act
            // Assert
            Assert.Equal(expected, Program.ArrayShift(test, value));
        }
    }
}
