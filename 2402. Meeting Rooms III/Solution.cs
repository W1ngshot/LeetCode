namespace LeetCode._2402._Meeting_Rooms_III;

public class Solution
{
    public int MostBooked(int n, int[][] meetings)
    {
        var sorted = meetings.OrderBy(x => x[0]).ToList();
        var rooms = new PriorityQueue<int, int>();
        for (var i = 0; i < n; i++)
            rooms.Enqueue(i, i);
        var ends = new PriorityQueue<int, long>();
        var counter = new int[n];
        long currentTime = 0;

        foreach (var i in sorted)
        {
            currentTime = Math.Max(currentTime, i[0]);
            DequeueAllForPriority(ends, rooms, currentTime);
            if (rooms.TryDequeue(out var room, out _))
            {
                counter[room]++;
                ends.Enqueue(room, currentTime + i[1] - i[0]);
            }
            else
            {
                ends.TryPeek(out var end, out var time);
                DequeueAllForPriority(ends, rooms, time);
                currentTime = time;
                var freeRoom = rooms.Dequeue();
                ends.Enqueue(freeRoom, time + i[1] - i[0]);
                counter[freeRoom]++;
            }
        }

        var max = 0;
        var maxIndex = 0;
        for (var i = 0; i < n; i++)
        {
            if (counter[i] > max)
            {
                max = counter[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    private void DequeueAllForPriority(PriorityQueue<int, long> queue, PriorityQueue<int, int> rooms, long prior)
    {
        while (queue.TryPeek(out var room, out var priority) && priority <= prior)
        {
            queue.Dequeue();
            rooms.Enqueue(room, room);
        }
    }
}