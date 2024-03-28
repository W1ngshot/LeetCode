namespace LeetCode._2958._Length_of_Longest_Subarray_With_at_Most_K_Frequency;

public class Solution
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        var max = 0;
        var dict = new Dictionary<int, int>();
        var start = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.TryGetValue(nums[i], out var value))
                dict[nums[i]] = 1;
            else
                dict[nums[i]] = ++value;
            
            if (value <= k)
            {
                if (i - start + 1 > max)
                    max = i - start + 1;
            }
            else
            {
                while (dict[nums[i]] > k && start <= i)
                {
                    dict[nums[start]]--;
                    start++;
                }
            }
        }

        return max;
    }
}