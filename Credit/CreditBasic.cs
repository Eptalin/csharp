using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Credit;

internal class CreditBasic
{
    public static string Validate(string card)
    {
        var length = card.Length;

        // Return Issuer if Luhn passes, else "INVALID"
        return PassesLuhn(card, length)
            ? GetIssuer(card, length)
            : "INVALID";
    }

    private static bool PassesLuhn(string card, int length)
    {
        var checksum = 0;
        var odd = true;
        int n;

        // Iterate over digits from right to left
        for (var i = length - 1; i >= 0; i--)
        {
            n = card[i] - '0';
            // Add digit
            if (odd)
            {
                checksum += n;
            } 
            // Multiply by 2 and add digits (8x2=16 → 1+6=7)
            else
            {
                n *= 2;
                checksum += (n > 9) ? n - 9 : n;
            }
            odd = !odd;
        }
        // Return true|false
        return checksum % 10 == 0;
    }

    private static string GetIssuer(string card, int length)
    {
        // Determine card issuer (if any)
        int.TryParse(card.AsSpan(0, 2), out int prefix);
        if (length == 15 && (prefix == 34 || prefix == 37))
        {
            return "AMEX";
        }
        if ((length == 13 || length == 16) && card[0] == '4')
        {
            return "VISA";
        }
        if (length == 16 && prefix >= 51 && prefix <= 55)
        {
            return "MASTERCARD";
        }
        return "INVALID";
    }
}
