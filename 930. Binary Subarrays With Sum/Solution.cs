namespace LeetCode._930._Binary_Subarrays_With_Sum;

public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        Dictionary<int, int> freq = [];
        int currentSum = 0, counter = 0;

        foreach (var num in nums)
        {
            currentSum += num;

            if (currentSum == goal)
                counter++;

            if (freq.TryGetValue(currentSum - goal, out var count))
                counter += count;

            if (freq.TryGetValue(currentSum, out var sumFreq))
                freq[currentSum] = 1 + sumFreq;
            else
                freq[currentSum] = 1;
        }

        return counter;
    }
}