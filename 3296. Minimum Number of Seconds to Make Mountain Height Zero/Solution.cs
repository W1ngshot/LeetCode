namespace LeetCode._3296._Minimum_Number_of_Seconds_to_Make_Mountain_Height_Zero;

public class Solution
{
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
    {
        var queue = new PriorityQueue<int, int>();
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < workerTimes.Length; i++)
            queue.Enqueue(i, workerTimes[i]);

        var max = 0;
        
        for (var i = 0; i < mountainHeight; i++)
        {
            var worker = queue.Dequeue();

            if (!dict.TryAdd(worker, 1))
                dict[worker]++;

            var count = dict[worker];
            if ((1 + count) * count * workerTimes[worker] / 2 > max)
                max = (1 + count) * count * workerTimes[worker] / 2;
            
            queue.Enqueue(worker, (1 + 1 + count) * (1 + count) * workerTimes[worker] / 2);
        }

        return max;
    }
}