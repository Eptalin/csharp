using Readability;

Console.Write("Text: ");
Passage passage = new(Console.ReadLine() ?? "");

Console.WriteLine($"Letters: {passage.LetterCount}");
Console.WriteLine($"Words: {passage.WordCount}");
Console.WriteLine($"Sentences: {passage.SentenceCount}");
Console.WriteLine($"Reading Level: {passage.ReadingLevel}");