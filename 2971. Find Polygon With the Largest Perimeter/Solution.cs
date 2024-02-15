namespace LeetCode._2971._Find_Polygon_With_the_Largest_Perimeter;

public class Solution
{
    public long LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        var prSum = new long[nums.Length];
        long sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            prSum[i] = sum;
        }

        for (var i = nums.Length - 1; i > 1; i--)
        {
            if (nums[i] < prSum[i - 1]) return prSum[i];
        }

        return -1;
    }
}