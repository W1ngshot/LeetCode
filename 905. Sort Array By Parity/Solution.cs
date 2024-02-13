namespace LeetCode._905._Sort_Array_By_Parity;

public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        var p = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                (nums[i], nums[p]) = (nums[p], nums[i]);
                p++;
            }
        }

        return nums;
    }
}