namespace LeetCode._3130._Find_All_Possible_Stable_Binary_Arrays_II;

public class Solution
{
    public int NumberOfStableArrays(int zero, int one, int limit)
    {
        const int mod = 1_000_000_007;
        var dp = new long[zero + 1, one + 1, 2];

        for (var i = 1; i <= Math.Min(zero, limit); i++)
            dp[i, 0, 0] = 1;
        for (var j = 1; j <= Math.Min(one, limit); j++)
            dp[0, j, 1] = 1;

        for (var i = 1; i <= zero; i++)
        {
            for (var j = 1; j <= one; j++)
            {
                dp[i, j, 0] = (dp[i - 1, j, 0] + dp[i - 1, j, 1]) % mod;
                if (i > limit)
                    dp[i, j, 0] = (dp[i, j, 0] - dp[i - limit - 1, j, 1] + mod) % mod;

                dp[i, j, 1] = (dp[i, j - 1, 0] + dp[i, j - 1, 1]) % mod;
                if (j > limit)
                    dp[i, j, 1] = (dp[i, j, 1] - dp[i, j - limit - 1, 0] + mod) % mod;
            }
        }

        return (int)((dp[zero, one, 0] + dp[zero, one, 1]) % mod);
    }
}