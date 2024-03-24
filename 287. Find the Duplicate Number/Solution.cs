namespace LeetCode._287._Find_the_Duplicate_Number;

public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        return nums.FirstOrDefault(num => !dict.TryAdd(num, 1));
    }
}