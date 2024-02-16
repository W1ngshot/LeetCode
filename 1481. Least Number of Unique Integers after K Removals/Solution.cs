namespace LeetCode._1481._Least_Number_of_Unique_Integers_after_K_Removals;

public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        var dict = arr.GroupBy(x => x)
            .OrderBy(x => x.Count())
            .Select(x => x.Count())
            .ToList();

        var count = dict.Count;
        foreach (var val in dict)
        {
            if (val > k) return count;
            k -= val;
            count--;
        }

        return count;
    }
}