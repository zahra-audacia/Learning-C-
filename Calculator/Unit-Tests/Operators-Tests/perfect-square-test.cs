using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.More;
using FluentAssertions;

namespace Unit_Tests.Operators_Tests
{
    public class perfect_square_test
    {
        [Fact]
        public void _25_is_a_perfect_square()
        {
            //arrange
            var input = 25;
            var expectedResult = true;

            //act
            var test = new Perfect_Square();
            var result = test.CheckIfPerfectSquare(input);

            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void _5_is_NOT_a_perfect_square()
        {
            //arrange
            var input = 5;
            var expectedResult = false;

            //act
            var test = new Perfect_Square();
            var result = test.CheckIfPerfectSquare(input);

            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void negative_values_are_false()
        {
            //arrange
            var input = -25;
            var expectedResult = false;

            //act
            var test = new Perfect_Square();
            var result = test.CheckIfPerfectSquare(input);

            //assert
            result.Should().Be(expectedResult);
        }
    }
}
