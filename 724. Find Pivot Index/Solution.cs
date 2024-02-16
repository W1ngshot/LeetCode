namespace LeetCode._724._Find_Pivot_Index;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var sum = nums.Sum();
        var leftSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - leftSum - nums[i])
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}