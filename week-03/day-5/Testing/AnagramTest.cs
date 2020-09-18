using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AnagramChecker
{
    public class AnagramTest
    {
        [Theory]
        [InlineData("abbaasssa", "vdsahdvsajda", false)]
        [InlineData("dog", "god", true)]

        public void AnagramTester(string input1, string input2, bool result)
        {
            // arrange
            var testingAnagram = new Anagram(input1, input2);
            // act
            var testOutput = testingAnagram.getAnagram();
            var expectedOutput = result;
            // assert
            Assert.Equal(expectedOutput, testOutput);
        }
    }
}
