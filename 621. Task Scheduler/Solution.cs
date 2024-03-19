namespace LeetCode._621._Task_Scheduler;

public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        var frequencies = tasks
            .GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .ToDictionary(x => x.Key, x => x.Count());

        var maxFreq = frequencies.First().Value - 1;
        var idle = maxFreq * n;

        foreach (var freq in frequencies.Values.Skip(1))
        {
            idle -= Math.Min(maxFreq, freq);
        }

        return tasks.Length + Math.Max(0, idle);
    }
}