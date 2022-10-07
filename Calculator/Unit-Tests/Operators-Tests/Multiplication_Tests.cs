using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;
using FluentAssertions;


namespace Unit_Tests.Operators_Tests
{
    public class Multiplication_Tests
    {
        [Fact]
        public void Multiplying_two_positive_integers_together()
        {
            decimal inputOne = 5;
            decimal inputTwo = 8;
            decimal expectedResult = 40;

            var multiplication = new Multiplication(inputOne,inputTwo);
            var result = multiplication.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Muliplying_two_negative_integers_together()
        {
            decimal inputOne = -10;
            decimal inputTwo = -4;
            decimal expectedResult = 40;

            var multiplication = new Multiplication(inputOne, inputTwo);
            var result = multiplication.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Multplying_a_negative_int_and_a_positive_int()
        {
            decimal inputOne = -10;
            decimal inputTwo = 3;
            decimal expectedResult = -30;


            var multiplication = new Multiplication(inputOne, inputTwo);
            var result = multiplication.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Multiplying_a_decimal_and_a_int()
        {
            decimal inputOne = -10;
            decimal inputTwo = 0.5m;
            decimal expectedResult = -5;


            var multiplication = new Multiplication(inputOne, inputTwo);
            var result = multiplication.Calculate();

            result.Should().Be(expectedResult);
        }
        [Fact]
        public void Multplying_by_zero()
        {
            decimal inputOne = 0;
            decimal inputTwo = 90293;
            decimal expectedResult = 0;


            var multiplication = new Multiplication(inputOne, inputTwo);
            var result = multiplication.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Multitplying_by_one()
        {
            decimal inputOne = 1;
            decimal inputTwo = 3435;
            decimal expectedResult = 3435;


            var multiplication = new Multiplication(inputOne, inputTwo);
            var result = multiplication.Calculate();

            result.Should().Be(expectedResult);
        }
    }
}
