namespace LeetCode._3854._Minimum_Operations_to_Make_Array_Parity_Alternating;

public class Solution
{
    public int[] MakeParityAlternating(int[] nums)
    {
        var firstOddCounter = 0;
        var firstEvenCounter = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0 && nums[i] % 2 != 0
                || i % 2 == 1 && nums[i] % 2 == 0)
                firstEvenCounter++;
            if (i % 2 == 1 && nums[i] % 2 != 0
                || i % 2 == 0 && nums[i] % 2 == 0)
                firstOddCounter++;
        }

        var minDiff = int.MaxValue;
        var minOperations = Math.Min(firstEvenCounter, firstOddCounter);

        if (firstEvenCounter == minOperations)
        {
            var diff = CalculateMinDiff(nums, minOperations, false);
            minDiff = Math.Min(diff, minDiff);
        }

        if (firstOddCounter == minOperations)
        {
            var diff = CalculateMinDiff(nums, minOperations);
            minDiff = Math.Min(diff, minDiff);
        }

        return [minOperations, minDiff];
    }

    private int CalculateMinDiff(int[] nums, int operations, bool isOddFirst = true)
    {
        var n = nums.Length;
        var options = new List<(int Value, int Index)>(nums.Length + operations);

        for (var i = 0; i < n; i++)
        {
            if (nums[i] % 2 == 0
                            == (i % 2 == 0 ? !isOddFirst : isOddFirst))
            {
                options.Add((nums[i], i));
            }
            else
            {
                options.Add((nums[i] - 1, i));
                options.Add((nums[i] + 1, i));
            }
        }

        options.Sort((first, second) => first.Value.CompareTo(second.Value));

        var minDiff = int.MaxValue;
        var left = 0;
        var uniqueCount = 0;
        var indexesCount = new int[n];

        for (var right = 0; right < options.Count; right++)
        {
            var index = options[right].Index;

            if (indexesCount[index] == 0)
                uniqueCount++;

            indexesCount[index]++;

            while (uniqueCount == n)
            {
                var diff = options[right].Value - options[left].Value;
                minDiff = Math.Min(minDiff, diff);

                var leftIndex = options[left].Index;
                indexesCount[leftIndex]--;

                if (indexesCount[leftIndex] == 0)
                    uniqueCount--;
                left++;
            }
        }

        return minDiff;
    }
}