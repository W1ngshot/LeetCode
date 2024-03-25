namespace LeetCode._442._Find_All_Duplicates_in_an_Array;

public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var result = new List<int>();

        foreach (var num in nums)
        {
            var index = Math.Abs(num) - 1;
            if (nums[index] < 0)
                result.Add(Math.Abs(num));
            nums[index] = -nums[index];
        }

        return result;
    }
}