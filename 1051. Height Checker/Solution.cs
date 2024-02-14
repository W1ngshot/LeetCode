namespace LeetCode._1051._Height_Checker;

public class Solution
{
    public int HeightChecker(int[] heights)
    {
        return heights.OrderBy(x => x)
            .Where((t, i) => heights[i] != t)
            .Count();
    }
}