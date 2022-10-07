using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.More;
using FluentAssertions;

namespace Unit_Tests.Operators_Tests
{
    public class fibonacci_test
    {
        [Fact]
        public void Test_for_0_number_of_elements()
        {
            //arrange 
            var input = 0;
            List<int> expectedResult = new List<int>() { };

            //act
            var test = new Fibonacci();
            var result = test.FibonacciSeries(input);

            //assert
            result.Should().Equal(expectedResult);
        }

        [Fact]
        public void Test_for_1_element()
        {

            var input = 1;
            List<int> expectedResult = new List<int>() {0};

            var test = new Fibonacci();
            var result = test.FibonacciSeries(input);

            result.Should().BeEquivalentTo(expectedResult);

        }

        [Fact]
        public void Test_for_2_elements()
        {

            var input = 2;
            List<int> expectedResult = new List<int>() { 0, 1 };

            var test = new Fibonacci();
            var result = test.FibonacciSeries(input);

            result.Should().BeEquivalentTo(expectedResult);

        }
        [Fact]
        public void Test_for_10_elements()
        {

            var input = 10;
            List<int> expectedResult = new List<int>() { 0, 1,1,2,3,5,8,13,21,34 };

            var test = new Fibonacci();
            var result = test.FibonacciSeries(input);

            result.Should().BeEquivalentTo(expectedResult);

        }

    }
}
