using System;
using System.Collections.Generic;
using System.Text;

namespace Readability
{
    internal class Passage
    {
        // Private Properties
        private int letterCount;
        private int wordCount;
        private int sentenceCount;

        // Public Properties
        public string Text { get; }

        public int LetterCount => letterCount;
        public int WordCount => wordCount;
        public int SentenceCount => sentenceCount;

        public string ReadingLevel => CalculateReadingLevel();

        // Constructor
        public Passage(string text)
        {
            Text = text;
            if (text.Length > 0) wordCount = 1;
            AnalyseText();
        }

        // Private helpers
        private void AnalyseText()
        {
            foreach (char c in Text)
            {
                if (Char.IsLetter(c))
                {
                    letterCount++;
                }
                if (Char.IsWhiteSpace(c))
                {
                    wordCount++;
                }
                if (c == '.' || c == '!' || c == '?')
                {
                    sentenceCount++;
                }
            }
        }

        private string CalculateReadingLevel()
        {
            var L = (double) LetterCount / WordCount * 100;
            var S = (double) SentenceCount / WordCount * 100;
            var CLI = (int) Math.Round(0.0588 * L - 0.296 * S - 15.8);

            if (CLI < 1) return "Below Grade 1";
            else if (CLI > 16) return "Grade 16+";
            else return $"Grade {CLI}";
        }
    }
}
