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

        public int CountRepeats()
        {
            string userString = GetInputString().ToLower();
            string userWord = GetInputWord().ToLower();

            string[] userStringWords = userString.Split(' ');

            //to remove punctuation
            for (int i = 0; i < userStringWords.Length; i++)
            {
                char[] currentWord = userStringWords[i].ToCharArray();
                foreach (char letter in currentWord)
                {
                    if (char.IsPunctuation(letter))
                    {
                        userStringWords[i] = userStringWords[i].Remove(Array.IndexOf(currentWord, letter));
                    }
                }
            }
            foreach (string word in userStringWords)
            {
                Console.WriteLine(word);
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
