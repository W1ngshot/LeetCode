namespace LeetCode._1295._Find_Numbers_with_Even_Number_of_Digits;

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Select(x => x.ToString().Length).Count(x => x % 2 == 0);
    }
}