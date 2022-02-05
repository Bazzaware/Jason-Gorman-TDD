using FluentAssertions;
using System;
using Xunit;

namespace FibonacciTests
{
    public class UnitTest1
    {
        [Fact]
        public void FirstNumberInSequenceIsZero()
        {
            Assert.Equal(0, GetFibonacciNumber(0));
        }


        [Fact]
        public void SecondNumberInSequenceIsOne()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(1, GetFibonacciNumber(1));

        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        public void FirstTwoNumbersAreSameAsIndex(int index,int expected)
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(expected,GetFibonacciNumber(index));
   
        }

        [Fact]
        public void ThirdNumberInSequenceIsOne()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(1, GetFibonacciNumber(2));

        }

        [Theory]
        [InlineData(2,1)]
        [InlineData(3,2)]
        public void ThirdNumbeOnIsIndexMinusOne(int index, int expected)
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(expected,GetFibonacciNumber(index));

        }

        [Fact]
        public void SixthNumberIsFive()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(5, GetFibonacciNumber(5));

        }

        [Theory]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(5,5)]
        public void ThirdNumberOnIsSumOfPreviousTwo(int index,int expected)
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(expected, GetFibonacciNumber(index));

        }

        [Fact]
        public void IndexMustBeAPositiveInteger()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => GetFibonacciNumber(-1));

        }
        
        private int GetFibonacciNumber(int index)
        {
            return new Fibonacci().getNumber(index);
        }

    }
}
