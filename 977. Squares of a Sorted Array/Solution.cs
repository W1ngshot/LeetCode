namespace LeetCode._977._Squares_of_a_Sorted_Array;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        var result = new int[nums.Length];

        var counter = right;
        while (right >= left)
        {
            if (Math.Abs(nums[right]) > Math.Abs(nums[left]))
            {
                result[counter] = nums[right] * nums[right];
                right -= 1;
            }
            else
            {
                result[counter] = nums[left] * nums[left];
                left += 1;
            }

            counter--;
        }

        return result;
    }
}