namespace LeetCode._1672._Richest_Customer_Wealth;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        var max = 0;
        for (var i = 0; i < accounts.Length; i++)
        {
            var sum = 0;
            for (var j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > max)
            {
                max = sum;
            }
        }

        return max;
    }
}