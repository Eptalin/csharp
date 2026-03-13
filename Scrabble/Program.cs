using Scrabble;

// Prompt players for words
Word word1 = new(GetWord("Player 1"));
Word word2 = new(GetWord("Player 2"));

// Report winner
Console.WriteLine(ReportWinner(word1.Score, word2.Score));

string GetWord(string player)
{
    string word;
    do
    {
        Console.Write($"{player}: ");
        word = Console.ReadLine() ?? "";
    } while (!word.All(char.IsLetter));
    return word;
}

string ReportWinner(int score1, int score2)
{
    if (score1 > score2)
    {
        return "Player 1 wins!";
    }
    else if (score2 > score1)
    {
        return "Player 2 wins!";
    }
    else
    {
        return "Tie!";
    }
}