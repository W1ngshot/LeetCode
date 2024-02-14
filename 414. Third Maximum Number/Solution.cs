namespace LeetCode._414._Third_Maximum_Number;

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        (int max1, int? max2, int? max3) = (nums[0], null, null);
        foreach (var num in nums)
        {
            if (num == max1 || num == max2 || num == max3)
                continue;

            if (num > max1)
            {
                (max1, max2, max3) = (num, max1, max2);
            }
            else if (max2 is null || num > max2)
            {
                (max2, max3) = (num, max2);
            }
            else if (max3 is null || num > max3)
            {
                max3 = num;
            }
        }

        return max3 ?? max1;
    }
}