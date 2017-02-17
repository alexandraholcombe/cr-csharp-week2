using Xunit;
using System;

namespace WordCounter
{
    public class RepeatCounterTest
    {
        [Fact]
        public void CountRepeats_ForWordNotInString_0()
        {
            string userInputString = "I love to code";
            string userInputWord = "program";
            RepeatCounter testRepeatCounter = new RepeatCounter(userInputString, userInputWord);
            int result = testRepeatCounter.CountRepeats();
            int expectedResult = 0;
            Assert.Equal(expectedResult, result);
        }
    }
}
