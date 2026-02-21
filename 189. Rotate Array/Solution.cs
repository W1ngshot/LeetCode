namespace LeetCode._189._Rotate_Array;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var filteredK = k % nums.Length;
        
        ReverseFromTo(nums, 0, nums.Length - 1);
        ReverseFromTo(nums, 0, filteredK - 1);
        ReverseFromTo(nums, filteredK, nums.Length - 1);
    }

    private static void ReverseFromTo(int[] arr, int start, int end)
    {
        var pointer = end;
        for (var i = start; i <= pointer; i++)
        {
            (arr[i], arr[pointer]) = (arr[pointer], arr[i]);
            pointer--;
        }
    }
}