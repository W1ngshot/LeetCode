namespace LeetCode._747._Largest_Number_At_Least_Twice_of_Others;

public class Solution
{
    public int DominantIndex(int[] nums)
    {
        int max = -1, maxIndex = 0, secondMax = -1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                (max, secondMax) = (nums[i], max);
                maxIndex = i;
            }
            else if (nums[i] > secondMax)
            {
                secondMax = nums[i];
            }
        }

        return max >= secondMax * 2 ? maxIndex : -1;
    }
}