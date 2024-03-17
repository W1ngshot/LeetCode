namespace LeetCode._57._Insert_Interval;

public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
            return [newInterval];
        
        var result = new List<int[]>();
        var isAdded = false;
        foreach (var interval in intervals)
        {
            if (IsOverlapping(interval, newInterval))
            {
                newInterval = [Math.Min(newInterval[0], interval[0]), Math.Max(newInterval[1], interval[1])];
            }
            else
            {
                if (!isAdded && newInterval[1] < interval[0])
                {
                    result.Add(newInterval);
                    isAdded = true;
                }

                result.Add(interval);
            }
        }

        if (!isAdded)
            result.Add(newInterval);

        return result.ToArray();
    }

    private bool IsOverlapping(int[] first, int[] second)
    {
        return second[0] >= first[0] && second[0] <= first[1]
               || second[1] >= first[0] && second[1] <= first[1]
               || first[0] >= second[0] && first[0] <= second[1]
               || first[1] >= second[0] && first[1] <= second[1];
    }
}