namespace LeetCode._992._Subarrays_with_K_Different_Integers;

public class Solution
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        return GetAllSubarraysForK(nums, k) - GetAllSubarraysForK(nums, k - 1);
    }

    private int GetAllSubarraysForK(int[] nums, int k)
    {
        int counter = 0, left = 0;
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.TryGetValue(nums[i], out var value))
                dict[nums[i]] = 1;
            else
                dict[nums[i]] = ++value;

            while (dict.Count > k)
            {
                if (dict[nums[left]]-- == 1)
                    dict.Remove(nums[left]);
                left++;
            }

            counter += i - left + 1;
        }

        return counter;
    }
}