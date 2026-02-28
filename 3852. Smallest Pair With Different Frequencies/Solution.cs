namespace LeetCode._3852._Smallest_Pair_With_Different_Frequencies;

public class Solution
{
    public int[] MinDistinctFreqPair(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
                dict[num]++;
        }

        var distinct = nums.Distinct().ToArray();
        Array.Sort(distinct);

        for (var i = 0; i < distinct.Length; i++)
        {
            for (var j = i + 1; j < distinct.Length; j++)
            {
                if (dict[distinct[i]] != dict[distinct[j]])
                {
                    return [distinct[i], distinct[j]];
                }
            }
        }

        return [-1, -1];
    }
}