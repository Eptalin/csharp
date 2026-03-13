using System;
using System.Collections.Generic;
using System.Text;

namespace Scrabble
{
    internal class Word
    {
        // Points for each letter, in order. A:1, B:3, ...
        private static readonly int[] points =
        {
            1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3,
            1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10
        };

        // Getters, with no setters.
        public string Text { get; }
        public int Score { get; }
        
        // Constructor
        public Word(string word)
        {
            Text = word.ToUpperInvariant();
            Score = CalculateScore(Text);
        }

        // Calculate word score.
        private static int CalculateScore(string word)
        {
            var score = 0;
            foreach (char letter in word)
            {
                score += points[letter - 'A'];
            }
            return score;
        }
    }
}
