using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;
using FluentAssertions;


namespace Unit_Tests.Operators_Tests
{
    public class PowerOf_Tests
    {
        [Fact]
        public void Positive_integer_to_the_power_of_a_positive_integer()
        {
            decimal inputOne = 3;
            decimal inputTwo = 2;
            decimal expectedResult = 9;

            var power = new PowerOf(inputOne, inputTwo);
            var result = power.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Positive_integer_to_the_power_of_a_negative_integer()
        {
            decimal inputOne = 25;
            decimal inputTwo = -2;
            decimal expectedResult = 0.0016m;

            var power = new PowerOf(inputOne,inputTwo);
            var result = power.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Negative_integer_to_the_power_of_a_positive_integer()
        {
            decimal inputOne = -2;
            decimal inputTwo = 2;
            decimal expectedReuslt = 4;

            var power = new PowerOf(inputOne, inputTwo);
            var result = power.Calculate();

            result.Should().Be(expectedReuslt);
        }

        [Fact]
        public void Negative_integer_to_the_power_of_a_negative_integer()
        {
            decimal inputOne = -2;
            decimal inputTwo = -2;
            decimal expectedResult = 0.25m;

            var power = new PowerOf(inputOne, inputTwo);
            var result = power.Calculate();

            result.Should().Be(expectedResult);

        }

        [Fact]
        public void Positive_decimal_to_the_power_of_a_positive_integer()
        {
            decimal inputOne = 0.5m;
            decimal inputTwo = 2;
            decimal expectedResult = 0.25m;

            var power = new PowerOf(inputOne, inputTwo);
            var result = power.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Negative_to_the_power_of_a_positive_integer()
        {
            decimal inputOne = -0.5m;
            decimal inputTwo = 2;
            decimal expectedResult = 0.25m;

            var power = new PowerOf(inputOne, inputTwo);
            var result = power.Calculate();

            result.Should().Be(expectedResult);
        }
     }
}
