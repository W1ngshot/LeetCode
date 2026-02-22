namespace LeetCode._167._Two_Sum_II___Input_Array_Is_Sorted;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var l = 0;
        var r = numbers.Length - 1;

        while (l < r)
        {
            var sum = numbers[l] + numbers[r];
            if (sum == target)
                return [l + 1, r + 1];

            if (sum > target)
                r--;
            else
                l++;
        }

        return new int[2];
    }
}