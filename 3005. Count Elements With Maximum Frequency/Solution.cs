namespace LeetCode._3005._Count_Elements_With_Maximum_Frequency;

public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
                dict[num]++;
        }

        int max = 0, count = 0;
        foreach (var value in dict.Values)
        {
            if (value > max)
            {
                max = value;
                count = 1;
            }
            else if (value == max)
                count++;
        }

        return max * count;
    }
}