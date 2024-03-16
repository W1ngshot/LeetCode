namespace LeetCode._525._Contiguous_Array;

public class Solution
{
    public int FindMaxLength(int[] nums)
    {
        var map = new Dictionary<int, int>();
        int max = 0, count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            count += nums[i] == 1 ? 1 : -1;

            if (count == 0)
                max = i + 1;

            if (!map.TryAdd(count, i))
                max = Math.Max(max, i - map[count]);
        }

        return max;
    }
}