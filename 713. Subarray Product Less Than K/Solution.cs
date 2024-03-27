namespace LeetCode._713._Subarray_Product_Less_Than_K;

public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        var result = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var j = i;
            var current = 1;
            while (j >= 0 && current * nums[j] < k)
            {
                current *= nums[j];
                j--;
            }

            result += i - j;
        }

        return result;
    }
}