using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Calculator.Models;
using FluentAssertions;

namespace Unit_Tests.Operators_Tests
{
    public class Division_Tests
    {
        [Fact]
        public void Dividing_two_positive_integers()
        {
            decimal inputOne = 100;
            decimal inputTwo = 10;
            decimal expectedResult = 10;

            var divide = new Division(inputOne, inputTwo);
            var result = divide.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Dividing_a_negative_by_positive()
        {
            decimal inputOne = -100;
            decimal inputTwo = 50;
            decimal expectedResult = -2;

            var divide = new Division(inputOne, inputTwo);
            var result = divide.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Dividing_two_negatives()
        {
            decimal inputOne = -100;
            decimal inputTwo = -20;
            decimal expectedResult = 5;

            var divide = new Division(inputOne, inputTwo);
            var result = divide.Calculate();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Dividing_by_1()
        {
            var inputOne = 100;
            var inputTwo = 1;
            var expectedResult = 100;

            var divide = new Division(inputOne, inputTwo);
            var result = divide.Calculate();

            result.Should().Be(expectedResult);
        }
    }
}
