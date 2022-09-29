using FluentAssertions;

namespace StringCalculator.Tests
{
    public class StringCalculatorUnitTests
    {
        [Fact]
        public void Add_WhenEmptyString_ShouldReturnZero()
        {
            var sut = new Domain.StringCalculator();
            var result = sut.Add("");

            result.Should().Be(0);
        }

        [Fact]
        public void Add_WhenNullString_ShouldReturnZero()
        {
            var sut = new Domain.StringCalculator();
            var result = sut.Add(null);

            result.Should().Be(0);
        }

        [Fact]
        public void Add_WhenMoreThanTwoNumbers_ShouldThrowArgumentException()
        {
            var sut = new Domain.StringCalculator();
            Action add = () => sut.Add("1,4,5");

            add.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Add_WhenConsecutiveCommas_ShouldThrowArgumentException()
        {
            var sut = new Domain.StringCalculator();
            Action add = () => sut.Add("1,,5");

            add.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Add_WhenContainsNonNumber_ShouldThrowArgumentException()
        {
            var sut = new Domain.StringCalculator();
            Action add = () => sut.Add("1,a");

            add.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Add_WhenValidInput_ReturnSum()
        {
            var sut = new Domain.StringCalculator();
            var result = sut.Add("1,4");

            result.Should().Be(5);
        }
    }
}