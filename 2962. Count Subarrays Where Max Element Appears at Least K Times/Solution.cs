namespace LeetCode._2962._Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times;

public class Solution
{
    public long CountSubarrays(int[] nums, int k)
    {
        long counter = 0;
        var dict = new Dictionary<int, int>();
        int max = nums.Max(), left = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.TryGetValue(nums[i], out var value))
                dict[nums[i]] = 1;
            else
                dict[nums[i]] = ++value;

            while (dict[nums[i]] >= k && nums[i] == max)
            {
                counter += nums.Length - i;
                dict[nums[left++]]--;
            }
        }

        return counter;
    }
}