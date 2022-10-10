using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Practice;

namespace TDD_Tests
{
    public class Area_Tests
    {
        [Fact]
        public void Radius_is_0()
        {
            //arrange
            var rad = 0;
            var expectedResult = 0;

            //act
            var test = new CalculateAreaOfACircle();
            var result = test.CalculateArea(rad);

            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void Radius_is_neagtive()
        {
            //arrange
            var rad = -29;

            //act
            var test = new CalculateAreaOfACircle();
            Action act = () => test.CalculateArea(rad);

            //assert
            act.Should().Throw<ArgumentOutOfRangeException>("radius");
        }
        [Fact]
        public void Radius_is_10()
        {
            //arrange
            var rad = 10;
            var expectedResult = 314.16;

            //act
            var test = new CalculateAreaOfACircle();
            var result = test.CalculateArea(rad);

            //assert
            result.Should().BeApproximately(expectedResult, 0.1);

        }
    }
}
