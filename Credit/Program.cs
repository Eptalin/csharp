using Credit;

// Validate a credit card number
var card = getCardNumber();

Console.WriteLine($"Card Type:   {CreditBasic.Validate(card)}");

string getCardNumber()
{
    string card;
    do
    {
        Console.Write("Card Number: ");
        card = Console.ReadLine() ?? "";
    } while (!card.All(char.IsDigit));
    return card;
}