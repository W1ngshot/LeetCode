namespace LeetCode._1680._Concatenation_of_Consecutive_Binary_Numbers;

public class Solution
{
    public int ConcatenatedBinary(int n)
    {
        var length = 1;
        var ans = 0L;
        for (var i = 1; i <= n; i++)
        {
            if (1 << length == i)
                length++;

            ans = ((ans << length) | (uint)i) % 1_000_000_007;
        }

        return (int)ans;
    }
}