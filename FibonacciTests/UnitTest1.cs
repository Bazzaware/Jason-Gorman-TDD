using FluentAssertions;
using System;
using Xunit;

namespace FibonacciTests
{
    public class UnitTest1
    {
        [Fact]
        public void firstNumberInSequenceIsZero()
        {
            Assert.Equal(0, getFibonacciNumber(0));
        }


        [Fact]
        public void secondNumberInSequenceIsOne()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(1, getFibonacciNumber(1));

        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        public void firstTwoNumbersAreSameAsIndex(int index,int expected)
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(expected,getFibonacciNumber(index));
   
        }

        [Fact]
        public void thirdNumberInSequenceIsOne()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(1, getFibonacciNumber(2));

        }

        [Theory]
        [InlineData(2,1)]
        [InlineData(3,2)]
        public void thirdNumbeOnIsIndexMinusOne(int index, int expected)
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(expected,getFibonacciNumber(index));

        }

        [Fact]
        public void sixthNumberIsFive()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(5, getFibonacciNumber(5));

        }

        [Theory]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(5,5)]
        public void thirdNumberOnIsSumOfPreviousTwo(int index,int expected)
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(expected, getFibonacciNumber(index));

        }

        [Fact]
        public void indexMustBeAPositiveInteger()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => getFibonacciNumber(-1));

        }
        
        private int getFibonacciNumber(int index)
        {
            return new Fibonacci().getNumber(index);
        }



    }
}
