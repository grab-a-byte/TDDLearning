using System;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            StringCalculator stringCalculator = new StringCalculator();

            int result =  stringCalculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Add_SingleNumber_ReturnsNumber(int number)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int result = stringCalculator.Add(number.ToString());

            Assert.Equal(number, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("3,4", 7)]
        public void Add_MultipleNumbersWithCommas_ReturnsSum(string input, int expected)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int result = stringCalculator.Add(input);

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("1,2,3,4,5", 15)]
        [InlineData("10,100,200", 310)]
        public void Add_UnknownAmountOfNumbersWithCommas_ReturnsSum(string input, int expected)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int result = stringCalculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("3\n4,5", 12)]
        public void Add_MultipleNumbersWithNewLines_ReturnsSum(string input, int expected)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int result = stringCalculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("//;\n1\n2,3", 6)]
        [InlineData("//&\n3\n4&5", 12)]
        public void Add_UserDefinedDelimeter_ReturnsSum(string input, int expected)
        {
            StringCalculator stringCalculator = new StringCalculator();

            int result = stringCalculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_NegativeNumber_ThrowsException()
        {
            StringCalculator stringCalculator = new StringCalculator();

            var exception = Assert.Throws<ArgumentException>(() => stringCalculator.Add("-1"));
            Assert.Equal("negatives not allowed", exception.Message);
        }
    }
}
