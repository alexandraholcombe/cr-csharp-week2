using System;

namespace WordCounter
{
    public class RepeatCounter
    {
        private string _inputString;
        private string _inputWord;

        public RepeatCounter(string inputString, string inputWord)
        {
            _inputString = inputString;
            _inputWord = inputWord;
        }

        public string GetInputString()
        {
            return _inputString;
        }

        public string GetInputWord()
        {
            return _inputWord;
        }

        public int CountRepeats()
        {
            string userString = GetInputString().ToLower();
            string userWord = GetInputWord().ToLower();

            string[] userStringWords = userString.Split(' ');
            int instanceCount = 0;

            foreach (string word in userStringWords)
            {
                if (word.Equals(userWord))
                {
                    instanceCount += 1;
                }
            }

            return instanceCount;
        }
    }
}
