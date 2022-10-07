
using Calculator.More;
using FluentAssertions;
namespace Unit_Tests.Operators_Tests
{
    public class Mod_Tests
    {
        [Fact]
        public void Mod_with_two_positive_integer_variables()
        {
            //act
            var inputOne = 10;
            var inputTwo = 2;
            var expectedResult = new List<int>() { 5, 0 };

            //arrange
            var test = new Mod();
            var result = test.ModFunction(inputOne, inputTwo);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }
        [Fact]
        public void Mod_with_a_negative_variable()
        {
            //act
            var inputOne = 10;
            var inputTwo = -2;
            var expectedResult = new List<int>() { 0, 0 };

            //arrange
            var test = new Mod();
            var result = test.ModFunction(inputOne, inputTwo);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }
        [Fact]
        public void Mod_with_two_negative_integer_variables()
        {
            //act
            var inputOne = -10;
            var inputTwo = -2;
            var expectedResult = new List<int>() { 0, 0 };

            //arrange
            var test = new Mod();
            var result = test.ModFunction(inputOne, inputTwo);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }
        [Fact]
        public void Mod_with_a_zero_variable()
        {
            //act
            var inputOne = 0;
            var inputTwo = 2;
            var expectedResult = new List<int>() { 0, 0 };

            //arrange
            var test = new Mod();
            var result = test.ModFunction(inputOne, inputTwo);

            //assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
