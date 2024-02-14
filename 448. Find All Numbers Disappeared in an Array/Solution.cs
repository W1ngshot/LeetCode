namespace LeetCode._448._Find_All_Numbers_Disappeared_in_an_Array;

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var index = Math.Abs(nums[i] - 1);
            nums[index] = -Math.Abs(nums[index]);
        }

        var res = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                res.Add(i + 1);
            }
        }

        return res;
    }
}