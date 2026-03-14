using System.Text;

namespace LeetCode._1415._The_k_th_Lexicographical_String_of_All_Happy_Strings_of_Length_n;

public class Solution
{
    private readonly char[,] _map =
    {
        { 'b', 'c' },
        { 'a', 'c' },
        { 'a', 'b' }
    };

    public string GetHappyString(int n, int k)
    {
        if (k > 3 << (n - 1))
            return "";

        var sb = new StringBuilder();
        sb.Append(((k - 1) >> (n - 1)) switch
        {
            0 => 'a',
            1 => 'b',
            _ => 'c'
        });


        for (var i = n - 2; i >= 0; i--)
        {
            var prevChar = sb[n - 2 - i];
            sb.Append(_map[prevChar - 'a', ((k - 1) >> i) & 1]);
        }

        return sb.ToString();
    }
}