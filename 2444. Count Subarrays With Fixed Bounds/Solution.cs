namespace LeetCode._2444._Count_Subarrays_With_Fixed_Bounds;

public class Solution
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        int minIndex = -1, maxIndex = -1, start = 0;
        var counter = 0L;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= minK && nums[i] <= maxK)
            {
                maxIndex = nums[i] == maxK ? i : maxIndex;
                minIndex = nums[i] == minK ? i : minIndex;
                counter += Math.Max(0, Math.Min(maxIndex, minIndex) - start + 1);
            }
            else
            {
                maxIndex = -1;
                minIndex = -1;
                start = i + 1;
            }
        }

        return counter;
    }
}