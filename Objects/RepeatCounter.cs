using System;
using System.Collections.Generic;

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

        public string PunctuationRemover(string thisWord)
        {
            char[] currentWord = thisWord.ToCharArray();
            foreach (char letter in currentWord)
            {
                if (char.IsPunctuation(letter))
                {
                    int here = Array.IndexOf(currentWord, letter);
                    thisWord = thisWord.Remove(here, 1);
                }
            }
            return thisWord;
        }

        public int CountRepeats()
        {
            string userString = GetInputString().ToLower();
            string userWord = GetInputWord().ToLower();

            //to remove punctuation from word
            userWord = PunctuationRemover(userWord);

            string[] userStringWords = userString.Split(' ');

            //to remove punctuation from string
            for (int i = 0; i < userStringWords.Length; i++)
            {
                userStringWords[i]=PunctuationRemover(userStringWords[i]);
            }

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
