namespace LeetCode._238._Product_of_Array_Except_Self;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
            result[i] = 1;

        int l = 1, r = 1;
        for (int i = 1, j = nums.Length - 2; i < nums.Length; i++, j--)
        {
            l *= nums[i];
            r *= nums[j];
            result[i] *= l;
            result[j] *= r;
        }

        return result;
    }
}