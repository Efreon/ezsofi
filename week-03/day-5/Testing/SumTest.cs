using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NumnSum
{
    public class SumTest
    {
        [Fact]
        public void SumReturnTest()
        {
            // arrange
            var numbers = new Sum(new List<int>() { -2, 3, 5, 7 });
            // act
            var returnSum = numbers.getSum();
            var expectedSum = 13;
            // assert
            Assert.Equal(expectedSum, returnSum);
        }

        [Fact]
        public void SumEmptyTest()
        {
            // arrange
            var numbers = new Sum(new List<int>() {});
            // act
            var returnSum = numbers.getSum();
            var expectedSum = 0;
            // assert
            Assert.Equal(expectedSum, returnSum);
        }

        [Fact]
        public void SumOneTest()
        {
            // arrange
            var numbers = new Sum(new List<int>() {5 });
            // act
            var returnSum = numbers.getSum();
            var expectedSum = 5;
            // assert
            Assert.Equal(expectedSum, returnSum);
        }

        [Fact]
        public void SumMultipleTest()
        {
            // arrange
            var numbers = new Sum(new List<int>() { 1,2,3,4,5,6,7,8,9,-5 });
            // act
            var returnSum = numbers.getSum();
            var expectedSum = 40;
            // assert
            Assert.Equal(expectedSum, returnSum);
        }

        [Fact]
        public void SumNullTest()
        {
            // arrange
            var numbers = new Sum(null);
            // act
            var returnSum = numbers.getSum();
            int expectedSum =0;
            // assert
            Assert.Equal(expectedSum, returnSum);
        }
    }
}
