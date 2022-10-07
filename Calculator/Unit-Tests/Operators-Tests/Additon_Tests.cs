using Calculator.Models;
using FluentAssertions;

namespace Unit_Tests
{
    public class Additon_Tests
    {
        [Fact]
        public void Adding_two_positives_together_equals_a_positive()
        {
            //Arrange
            decimal inputOne = 1;
            decimal inputTwo = 2;
            decimal expectedResult = 3;

            //Act
            var addition = new Addition(inputOne,inputTwo);
            var result = addition.Calculate();

            //Assert 
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Adding_a_positive_and_a_negative_together()
        {
            decimal inputOne = 1;
            decimal inputTwo = -4;
            decimal expectedResult = -3;

            var addition = new Addition(inputTwo,inputOne);
            var result = addition.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Adding_two_negatives_together_equals_a_negative()
        {
            decimal inputOne = -4;
            decimal inputTwo = -2;
            decimal expectedResult = -6;

            var addition = new Addition(inputTwo,inputOne);
            var result = addition.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Adding_two_non_integer_values()
        {
            decimal inputOne = 0.01m;
            decimal inputTwo = 0.03m;
            decimal expectedResult = 0.04m;

            var addition = new Addition(inputOne, inputTwo);
            var result = addition.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Adding_an_integer_and_a_decimal_together()
        {
            decimal inputOne = 2;
            decimal inputTwo = 0.5m;
            decimal expectedResult = 2.5m;

            var addition = new Addition(inputOne, inputTwo);
            var result = addition.Calculate();

            result.Should().Be(expectedResult);
        }
    }
}