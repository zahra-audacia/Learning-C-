using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;
using FluentAssertions;

namespace Unit_Tests.Operators_Tests
{
    public class Subtraction_Tests
    {
        [Fact]
        public void Subtracting_two_positive_integers_with_the_first_input_being_larger()
        {
            decimal inputOne = 10;
            decimal inputTwo = 2;
            decimal expectedResult = 8;

            var subtraction = new Subtraction(inputOne, inputTwo);
            var result = subtraction.Calculate();

            result.Should().Be(expectedResult);

        }

        [Fact]
        public void Subtracting_two_positive_integers_with_the_first_input_being_smaller()
        {
            decimal inputOne = 1;
            decimal inputTwo = 2;
            decimal expectedReslt = -1;

            var subtraction = new Subtraction(inputOne, inputTwo);
            var result = subtraction.Calculate();

            result.Should().Be(expectedReslt);
        }

        [Fact]
        public void Subtracting_a_negative_integer_from_a_positive_integers()
        {
            var inputOne = 10;
            var inputTwo = -2;
            var expectedResult = 12;

            var subtraction = new Subtraction(inputOne, inputTwo);
            var result = subtraction.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Subtracting_two_negative_integers()
        {
            var inputOne = -10;
            var inputTwo = -10;
            var expectedResult = 0;

            var subtraction = new Subtraction(inputOne, inputTwo);
            var result = subtraction.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Subtracting_a_decimal_from_an_integer()
        {
            decimal inputOne = 5;
            decimal inputTwo = 0.5m;
            decimal expectedResult = 4.5m;

            var subtraction = new Subtraction(inputOne, inputTwo);
            var result = subtraction.Calculate();

            result.Should().Be(expectedResult);

        }

        [Fact]
        public void Subtracting_a_decimal_from_a_decimal()
        {
            decimal inputOne = 9.5m;
            decimal inputTwo = 0.25m;
            decimal expectedResult = 9.25m;

            var subtraction = new Subtraction(inputOne, inputTwo);
            var result = subtraction.Calculate();

            result.Should().Be(expectedResult);
        }
    }
}
