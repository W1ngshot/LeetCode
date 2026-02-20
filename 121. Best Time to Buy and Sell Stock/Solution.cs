namespace LeetCode._121._Best_Time_to_Buy_and_Sell_Stock;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var least = prices[0];
        var maxDiff = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            if (maxDiff < prices[i] - least)
                maxDiff = prices[i] - least;
            
            if (prices[i] < least)
                least = prices[i];
        }

        return maxDiff;
    }
}