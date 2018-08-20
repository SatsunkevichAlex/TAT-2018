using System;
using NUnit.Framework;
using task_2;

namespace task2.Tests
{
    [TestFixture]
    class SquareCalculatorTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(2.5, 2, 5)]
        [TestCase(5, 2.5, 12.5)]
        [Test]
        public void GetSquare_CalculateSquare_CorrectSquare(double a, double b, double result)
        {
            SquareCalculator squareCalculator = new SquareCalculator();
            double square = squareCalculator.GetSquare(a, b);
            Assert.AreEqual(result, square);
        }

        [TestCase(-2.7, 2.2)]
        [TestCase(2.1, -2.4)]
        [Test]
        public void CalculateSquare_InvalidInputException(double a, double b)
        {
            SquareCalculator squareCalculator = new SquareCalculator();
            Assert.Throws<Exception>
            (
                () => squareCalculator.GetSquare(a, b)
            );
        }
    }
}
