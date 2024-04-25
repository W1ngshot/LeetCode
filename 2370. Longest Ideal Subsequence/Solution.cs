namespace LeetCode._2370._Longest_Ideal_Subsequence;

public class Solution
{
    public int LongestIdealString(string s, int k)
    {
        var dp = new int[26];
        var maxLen = 0;

        foreach (var ch in s)
        {
            var i = ch - 'a';
            var max = 0;

            for (var j = 0; j < 26; j++)
            {
                if (Math.Abs(i - j) <= k)
                {
                    max = Math.Max(max, dp[j]);
                }
            }

            dp[i] = max + 1;
            maxLen = Math.Max(maxLen, dp[i]);
        }

        return maxLen;
    }
}