namespace LeetCode._1._Two_Sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var exists = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (exists.TryGetValue(target - nums[i], out var value))
                return [i, value];
            exists[nums[i]] = i;
        }

        return [];
    }
}