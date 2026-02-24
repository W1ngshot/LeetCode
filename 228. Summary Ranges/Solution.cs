namespace LeetCode._228._Summary_Ranges;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
            return new List<string>();

        var result = new List<string>();

        var startIndex = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[startIndex] == i - startIndex)
                continue;

            result.Add(i - 1 == startIndex
                ? nums[startIndex].ToString()
                : $"{nums[startIndex]}->{nums[i - 1]}");
            startIndex = i;
        }

        result.Add(nums.Length - 1 == startIndex
            ? nums[startIndex].ToString()
            : $"{nums[startIndex]}->{nums[^1]}");

        return result;
    }
}