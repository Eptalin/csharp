namespace Cash;

internal class CashBasic
{
    public static int Solve(int change)
    {
        int n = 0;
        int[] coins = { 25, 10, 5, 1 };

        foreach (int coin in coins)
        {
            n += change / coin;
            change %= coin;
        }

        return n;
    }
}
