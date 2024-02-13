namespace LeetCode._283._Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var p1 = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (p1 != i && nums[i] != 0)
            {
                (nums[i], nums[p1]) = (nums[p1], nums[i]);
                p1++;
            }
        }
    }
}