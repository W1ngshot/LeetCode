namespace LeetCode._310._Minimum_Height_Trees;

public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1)
            return [0];

        var adjList = new List<int>[n];
        var degrees = new int[n];

        for (var i = 0; i < n; i++)
        {
            adjList[i] = [];
        }

        foreach (var edge in edges)
        {
            adjList[edge[0]].Add(edge[1]);
            adjList[edge[1]].Add(edge[0]);
            degrees[edge[0]]++;
            degrees[edge[1]]++;
        }

        var leaves = new Queue<int>();

        for (var i = 0; i < n; i++)
        {
            if (degrees[i] == 1) leaves.Enqueue(i);
        }

        while (n > 2)
        {
            var leavesSize = leaves.Count;
            n -= leavesSize;

            for (var i = 0; i < leavesSize; i++)
            {
                var leaf = leaves.Dequeue();

                foreach (var neighbor in adjList[leaf])
                {
                    degrees[neighbor]--;
                    if (degrees[neighbor] == 1) leaves.Enqueue(neighbor);
                }
            }
        }

        return leaves.ToList();
    }
}