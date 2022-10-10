using FluentAssertions;
using TDD_Practice;

namespace TDD_Tests
{
    public class dateTimes_tests
    {
        [Fact]
        public void Times_are_The_same()
        {
            //arrange
            var inputOne = new DateTime(2021,12,23,09,09,08);
            var inputTwo = new DateTime(2021, 12, 23, 09, 09, 08);
            var expectedResult = 0;
            //act
            var test = new dateTimes();
            var result = test.differenceBetweenTwoTimes(inputOne, inputTwo);
            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void Times_are_seconds_Apart()
        {
            //arrange
            var inputOne = new DateTime(2021, 12, 23, 09, 09, 08);
            var inputTwo = new DateTime(2021, 12, 23, 09, 09, 04);
            var expectedResult = 4;
            //act
            var test = new dateTimes();
            var result = test.differenceBetweenTwoTimes(inputOne, inputTwo);
            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void Times_are_The_minutes_apart()
        {
            //arrange
            var inputOne = new DateTime(2021, 12, 23, 09, 09, 08);
            var inputTwo = new DateTime(2021, 12, 23, 09, 04, 07);
            var expectedResult = 301;
            //act
            var test = new dateTimes();
            var result = test.differenceBetweenTwoTimes(inputOne, inputTwo);
            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void Times_are_hours_apart()
        {
            //arrange
            var inputOne = new DateTime(2021, 12, 23, 09, 09, 08);
            var inputTwo = new DateTime(2021, 12, 23, 07, 05, 01);
            var expectedResult = 7447;
            //act
            var test = new dateTimes();
            var result = test.differenceBetweenTwoTimes(inputOne, inputTwo);
            //assert
            result.Should().Be(expectedResult);
        }
        [Fact]
        public void inputTwo_is_later_than_inputOne()
        {
            //arrange
            var inputOne = new DateTime(2021, 12, 23, 07, 05, 01);
            var inputTwo= new DateTime(2021, 12, 23, 09, 09, 08);
            var expectedResult = 7447;
            //act
            var test = new dateTimes();
            var result = test.differenceBetweenTwoTimes(inputOne, inputTwo);
            //assert
            result.Should().Be(expectedResult);
        }

    }
}
