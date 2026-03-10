using System.Runtime.InteropServices;

namespace Cash;

internal class CashLinq
{
    public static int Solve(int change)
    {
        var coins = new[] { 25, 10, 5, 1 };

        // Aggregate(seed, lambda function)
        var result = coins.Aggregate(
            // Overload the seed with two variables using a tuple
            (remaining: change, count: 0),
            // Input seed ("state") and coin into lambda function
            (state, coin) => (
                remaining: state.remaining % coin,
                count: state.count + state.remaining / coin
            )                        
        );                           
                                     
        return result.count;         
    }
}