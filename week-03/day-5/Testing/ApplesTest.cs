using System;
using Xunit;

namespace ApplesText
{
    public class ApplesTest
    {
        [Fact]
        public void TextReturnTest()
        {
            // arrange
            var apple = new Apples("apple");

            // act
            var returnText = apple.getApple();
            var expectedText = "apple";

            // assert
            Assert.Equal(expectedText, returnText);
        }
    }
}
