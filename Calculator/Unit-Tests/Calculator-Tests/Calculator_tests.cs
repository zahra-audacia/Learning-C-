using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Calculator.Models;

namespace Unit_Tests.Calculator_Tests
{
    public class Calculator_tests
    {
        [Fact]
        public void Test_that_the_addition_operation_works()
        {
            //arrange
            var input = "2+2";
            var output = 4;
            //act
            var test = new CalculatorV2();
            var result = test.ParseInput(input);

            //assert
            result.Should().Be(output);
        }
        [Fact]
        public void Test_that_the_subtraction_operation_works()
        {
            //arrange
            var input = "2-2";
            var output = 0;
            //act
            var test = new CalculatorV2();
            var result = test.ParseInput(input);

            //assert
            result.Should().Be(output);
        }
        [Fact]
        public void Test_that_the_multiplication_operation_works()
        {
            //arrange
            var input = "2*3";
            var output = 6;
            //act
            var test = new CalculatorV2();
            var result = test.ParseInput(input);

            //assert
            result.Should().Be(output);
        }
        [Fact]
        public void Test_that_the_division_operation_works()
        {
            //arrange
            var input = "8/4";
            var output = 2;
            //act
            var test = new CalculatorV2();
            var result = test.ParseInput(input);

            //assert
            result.Should().Be(output);
        }

        [Fact]
        public void Test_that_the_multiple_of_the_addition_operation_works()
        {
            //arrange
            var input = "2+2+2";
            var output = 6;
            //act
            var test = new CalculatorV2();
            var result = test.ParseInput(input);

            //assert
            result.Should().Be(output);
        }
        [Fact]
        public void Test_that_the_multiple_of_the_subtraction_operation_works()
        {
            //arrange
            var input = "22 -2 -2";
            var output = 18;
            //act
            var test = new CalculatorV2();
            var result = test.ParseInput(input);

            //assert
            result.Should().Be(output);
        }
    }
}
