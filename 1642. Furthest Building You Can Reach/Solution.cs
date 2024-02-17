namespace LeetCode._1642._Furthest_Building_You_Can_Reach;

public class Solution
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var queue = new PriorityQueue<int, int>();
        for (var i = 0; i < heights.Length - 1; i++)
        {
            var dif = heights[i + 1] - heights[i];
            if (dif <= 0)
                continue;

            queue.Enqueue(dif, dif);

            if (queue.Count > ladders)
                bricks -= queue.Dequeue();

            if (bricks < 0)
                return i;
        }

        return heights.Length - 1;
    }
}