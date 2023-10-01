using Fibonacci.Domain.Services.Implementation;
using System;

namespace Fibonacci.Test
{
    public class FibonacciServiceTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(10, 55)]
        public void CalculateFibonacci_Returns_CorrectResult(int n, int expectedResult)
        {
            // Arrange
            var fibonacciService = new FibonacciService();

            // Act
            int result = fibonacciService.CalculateFibonacci(n);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, new int[] { 1, 1 })]
        [InlineData(2, new int[] { 1, 1 })]
        [InlineData(3, new int[] { 1, 1, 2 })]
        [InlineData(4, new int[] { 1, 1, 2, 3 })]
        [InlineData(5, new int[] { 1, 1, 2, 3, 5 })]
        [InlineData(10, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        public void GenerateFibonacciSequence_Returns_CorrectResult(int n, int[] expectedSequence)
        {
            // Arrange
            var fibonacciService = new FibonacciService();

            // Act
            var result = fibonacciService.GenerateFibonacciSequence(n);

            // Assert
            Assert.Equal(expectedSequence, result);
        }

        [Fact]
        public void CalculateFibonacci_Throws_Exception_For_NegativeInput()
        {
            // Arrange
            var fibonacciService = new FibonacciService();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => fibonacciService.CalculateFibonacci(-1));
        }

        [Fact]
        public void GenerateFibonacciSequence_Throws_Exception_For_NegativeInput()
        {
            // Arrange
            var fibonacciService = new FibonacciService();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => fibonacciService.GenerateFibonacciSequence(-1));
        }
    }
}
