namespace LeetCode._922._Sort_Array_By_Parity_II;

public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        var p = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (p % 2 == nums[p] % 2)
            {
                if (p != i)
                {
                    i--;
                }

                p++;
            }
            else if (p % 2 == nums[i] % 2)
            {
                (nums[i], nums[p]) = (nums[p], nums[i]);
                p++;
            }
        }

        return nums;
    }
}