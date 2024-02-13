namespace LeetCode._26._Remove_Duplicates_from_Sorted_Array;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var k = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[k] != nums[i])
            {
                nums[++k] = nums[i];
            }
        }

        return k + 1;
    }
}