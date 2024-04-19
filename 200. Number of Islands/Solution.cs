namespace LeetCode._200._Number_of_Islands;

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var counter = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    counter++;
                    DestroyIsland(grid, i, j);
                }
            }
        }

        return counter;
    }

    private void DestroyIsland(char[][] grid, int i, int j)
    {
        var queue = new Queue<(int, int)>();
        queue.Enqueue((i, j));

        while (queue.TryDequeue(out var point))
        {
            if (point.Item1 < 0 || point.Item1 == grid.Length ||
                point.Item2 < 0 || point.Item2 == grid[0].Length ||
                grid[point.Item1][point.Item2] == '0')
                continue;

            grid[point.Item1][point.Item2] = '0';

            queue.Enqueue((point.Item1 - 1, point.Item2));
            queue.Enqueue((point.Item1 + 1, point.Item2));
            queue.Enqueue((point.Item1, point.Item2 - 1));
            queue.Enqueue((point.Item1, point.Item2 + 1));
        }
    }
}