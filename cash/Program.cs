using Cash;

var change = GetPositiveInt();
Console.WriteLine($"Basic: {CashBasic.Solve(change)}");
Console.WriteLine($"Linq:  {CashLinq.Solve(change)}");

int GetPositiveInt()
{
    string input;
    int change;
    do
    {
        Console.Write("Amount owed: ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out change) || change <= 0);
    return change;
}