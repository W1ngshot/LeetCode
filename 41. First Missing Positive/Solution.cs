namespace LeetCode._41._First_Missing_Positive;

public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        var length = nums.Length;
        for (var i = 0; i < length; i++)
        {
            if (nums[i] <= 0)
                nums[i] = length + 1;
        }

        for (var i = 0; i < length; i++)
        {
            var val = Math.Abs(nums[i]) - 1;
            if (Math.Abs(nums[i]) <= length && nums[val] > 0)
            {
                nums[val] = -nums[val];
            }
        }

        for (var i = 0; i < length; i++)
        {
            if (nums[i] > 0)
                return i + 1;
        }

        return length + 1;
    }
}