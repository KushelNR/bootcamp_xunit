using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimpleCalculator.Tests
{
    public class CalculationTests
    {
        [Fact]
        public void Calculation_GivenTwoNumbers_ReturnTotals()
        {
            //Arrange
            int num1 = 5;
            int num2 = 10;
            int expected = 15;
            var calService = new CalculationService();

            //Act
            var result = calService.AddNumber(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(20, 5, 4)]
        [InlineData(50, 5, 10)]
        [InlineData(10, 5, 2)]
        public void Calculation_GivenTwoNumbers_ReturnDivide(int num1, int num2, int expected)
        {
            //Arrange
            var calService = new CalculationService();

            //Act
            var result = calService.DivideNumbers(num1, num2);

            //Assert
            Assert.Equal(expected, result);

        }
        [Fact]
        [Trait("Speed","QuickTest")]
        public void Calculation_GivenZero_ReturnException()
        {
            //Arrange
            int num1 = 100;
            int num2 = 0;
            var calService = new CalculationService();

            //Act
            Assert.Throws<DivideByZeroException>(() => calService.DivideNumbers(num1, num2));
        }

        [Fact]
        [Trait("Speed", "QuickTest")]
        public void Calculation_GivenNames_ReturnFullName()
        {
            //Arrange
            string firstName = "John";
            string lastName = "Doe";
            string expected = "John Doe";

            var calService = new CalculationService();

            //Act
            string result = calService.GetFullName(firstName, lastName);

            //Assert
            Assert.Equal(expected, result);
            Assert.Contains("Doe", result);
        }
    }
}
