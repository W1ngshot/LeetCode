namespace LeetCode._1480._Running_Sum_of_1d_Array;

public class Solution {
    public int[] RunningSum(int[] nums) {
        var sum = 0;
        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            result[i] = sum;
        }
        return result;
    }
}