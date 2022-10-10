using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Practice;

namespace TDD_Tests
{
    public class Roman_Numerals_Tests
    {
       

        [Fact]
        public void Input_of_0_should_throw_an_exception()
        {
            //arrange
            var num = 0;
            
            //act
            var test = new RomanNumerals();
            Action result = () => test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Throw<ArgumentOutOfRangeException>("must be a number greater than 0");
        }

        [Fact]
        public void Input_of_a_negative_number_should_throw_an_exception()
        {
            //arrange
            var num = -29;


            //act
            var test = new RomanNumerals();
            Action result = () => test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Throw<ArgumentOutOfRangeException>("must be a number greater than 0");
        }

        [Fact]
     public void Check_value_of_1_is_correctly_converted()
        {
            //arrange
            var num = 1;
            var expectedResult = "I";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_3_is_correctly_converted()
        {
            //arrange
            var num = 3;
            var expectedResult = "III";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_4_is_correctly_converted()
        {
            //arrange
            var num = 4;
            var expectedResult = "IV";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_5_is_correctly_converted()
        {
            //arrange
            var num = 5;
            var expectedResult = "V";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_6_is_correctly_converted()
        {
            //arrange
            var num = 6;
            var expectedResult = "VI";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_9_is_correctly_converted()
        {
            //arrange
            var num = 9;
            var expectedResult = "IX";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_10_is_correctly_converted()
        {
            //arrange
            var num = 10;
            var expectedResult = "X";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_24_is_correctly_converted()
        {
            //arrange
            var num = 24;
            var expectedResult = "XXIV";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_240_is_correctly_converted()
        {
            //arrange
            var num = 240;
            var expectedResult = "CCXL";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_100_is_correctly_converted()
        {
            //arrange
            var num = 100;
            var expectedResult = "C";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_1000_is_correctly_converted()
        {
            //arrange
            var num = 1000;
            var expectedResult = "M";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Check_value_of_500_is_correctly_converted()
        {
            //arrange
            var num = 500;
            var expectedResult = "D";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void Check_value_of_888_is_correctly_converted()
        {
            //arrange
            var num = 888;
            var expectedResult = "DCCCLXXXVIII";

            //act
            var test = new RomanNumerals();
            var result = test.ConvertToRomanNumerals(num);

            //assert
            result.Should().Be(expectedResult);
        }
    }
}
