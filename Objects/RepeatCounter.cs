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
            string userString = GetInputString();
            string userWord = GetInputWord();

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
            // if (userString.Equals(userWord))
            // {
            //     return 1;
            // }
            // else if (userString.Contains(userWord))
            // {
            //     return 1;
            // }
            // else
            // {
            //     return 0;
            // }
        }
    }
}
