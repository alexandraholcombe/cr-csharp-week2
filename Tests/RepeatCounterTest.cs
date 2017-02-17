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

        [Fact]
        public void CountRepeats_ForWordIsString_1()
        {
            string userInputString = "bananas";
            string userInputWord = "bananas";
            RepeatCounter testRepeatCounter = new RepeatCounter(userInputString, userInputWord);
            int result = testRepeatCounter.CountRepeats();
            int expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountRepeats_ForWordInStringOnce_1()
        {
            string userInputString = "I love to code";
            string userInputWord = "code";
            RepeatCounter testRepeatCounter = new RepeatCounter(userInputString, userInputWord);
            int result = testRepeatCounter.CountRepeats();
            int expectedResult = 1;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountRepeats_ForWordInStringMultipleTimes_wordcount()
        {
            string userInputString = "What's better than coding? Nothing is better than coding.";
            string userInputWord = "better";
            RepeatCounter testRepeatCounter = new RepeatCounter(userInputString, userInputWord);
            int result = testRepeatCounter.CountRepeats();
            int expectedResult = 2;
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountRepeats_ForWordInStringCapitalized_wordcount()
        {
            string userInputString = "What's Better than coding? Nothing is BETTER than coding.";
            string userInputWord = "better";
            RepeatCounter testRepeatCounter = new RepeatCounter(userInputString, userInputWord);
            int result = testRepeatCounter.CountRepeats();
            int expectedResult = 2;
            Assert.Equal(expectedResult, result);
        }
    }
}
