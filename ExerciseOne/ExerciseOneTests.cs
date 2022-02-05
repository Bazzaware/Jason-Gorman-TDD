using FluentAssertions;
using System.Collections.Generic;
using Xunit;
using System;

namespace ExerciseOneTests
{
    public class ExerciseOneTests
    {
        [Fact]
        public void numberShouldBeLessThanOneThousand()
        {
            // Arrange

            // Act
            int result = new NumberGenerator().getNumber();

            // Assert
            Assert.InRange(result,0,1000);
        }

        [Fact]
        public void shouldRetunListInRange()
        {
            // Arrange
            int range = 10;

            // Act
            List<int> results = CallNumberGenerator(range);

            // Assert
            foreach (var item in results)
            {
                item.Should().BeInRange(0, 1000);
            }
        }

        private static List<int> CallNumberGenerator(int range)
        {
            List<int> results = new NumberGenerator().numberRange(range);
            results.Count.Should().Be(range);
            return results;
        }

        [Theory]
        [InlineData(40)]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(23)]
        public void ShouldReturnAllNumbersInRange(int range)
        {
            // Arrange

            // Act
            List<int> results = CallNumberGenerator(range);

            // Assert
            foreach (var item in results)
            {
                item.Should().BeInRange(0, 1000);
            }


        }

    }

    public class RomanNumeralConverterTests
    {
        [Fact]
        public void ShouldConvertIntergerOneToRoman()
        {
            // Arrange
            int interger = 1;

            // Act
            string result = new RomanNumeral().convertIntToRoman(interger);

            // Assert
            result.Should().Be("I");

        }

        [Fact]
        public void shouldConvertIntergerFiveToRoman()
        {
            // Arrange
            int interger = 5;

            // Act
            string  result = new RomanNumeral().convertIntToRoman(interger);

            // Assert
            result.Should().Be("V");

        }

        [Theory]
        [InlineData("I",1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        public void ShouldConvertAllUnitIntergersToRoman(string expected,int interger)
        {
            // Arrange

            // Act
            string result = new RomanNumeral().convertIntToRoman(interger);

            // Assert
            result.Should().Be(expected);

        }

        //TODO: Check why this is not working.
        [Fact(Skip = "Cant get this to test for exceptions")]
        public void shouldThrowKeyNotFoundExceptionWhenInvalidIntergerPassed()
        {
            // Arrange
            object interger = null;

            // Act
            object result = null;

            // Assert
            //result.GetType(KeyNotFoundException).Where(e => e.Message.StartsWith($"{interger} not found."));

        }
    }

}
