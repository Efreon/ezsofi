using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LetterCounting
{
    public class CountLettersTest
    {
        [Fact]
        public void ContLettersTesting()
        {
            // arrange
            var inputText = new CountLetters("zsófi");

            // act
            var testText = inputText.getLettersCounted();
            var expected = new Dictionary<char, int>() {    { 'z', 1},
                                                            {'s', 1 },
                                                            { 'ó', 1},
                                                            { 'f', 1},
                                                            {'i', 1 }};
            //assert
            Assert.Equal(expected, testText);
        }

        [Fact]
        public void ContLettersMultipleTesting()
        {
            // arrange
            var inputText = new CountLetters("baasadsaasknrjraenra");

            // act
            var testText = inputText.getLettersCounted();
            var expected = new Dictionary<char, int>() {    {'b', 1},
                                                            {'a', 7 },
                                                            {'s', 3},
                                                            {'d', 1},
                                                            {'k', 1 },
                                                            {'n', 2 },
                                                            {'r', 3 },
                                                            {'j', 1 },
                                                            {'e', 1 }};
            //assert
            Assert.Equal(expected, testText);
        }


    }
}
