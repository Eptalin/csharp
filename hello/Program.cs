// Prompt user for input
Console.Write("What's your name? ");

// Accept user input
string name = Console.ReadLine();

// Empty string/null set to World
if (String.IsNullOrEmpty(name))
{
    name = "World";
}

// Print output
Console.WriteLine($"Hello, {name}!");