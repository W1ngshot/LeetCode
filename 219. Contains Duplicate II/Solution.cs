namespace LeetCode._219._Contains_Duplicate_II;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var slidingWindow = new HashSet<int>(k + 1);

        for (var i = 0; i < Math.Min(k, nums.Length); i++)
        {
            if (!slidingWindow.Add(nums[i]))
                return true;
        }

        for (var i = k; i < nums.Length; i++)
        {
            if (!slidingWindow.Add(nums[i]))
                return true;
            
            slidingWindow.Remove(nums[i - k]);
        }
        
        return false;
    }
}