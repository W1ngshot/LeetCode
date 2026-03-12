namespace LeetCode._3600._Maximize_Spanning_Tree_Stability_with_Upgrades;

public class Solution
{
    public int MaxStability(int n, int[][] edges, int k)
    {
        var necessary = edges.Where(x => x[3] == 1).ToList();
        var unnecessary = edges.Where(x => x[3] == 0).ToArray();

        if (necessary.Count > n - 1)
            return -1;
        
        Array.Sort(unnecessary, (x, y) => y[2] - x[2]);

        var weights = new List<int>();
        var dsu = new Dsu(n);
        var min = int.MaxValue;
        foreach (var edge in necessary)
        {
            if (!dsu.Union(edge[0], edge[1]))
                return -1;
            if (edge[2] < min)
                min = edge[2];
        }

        foreach (var edge in unnecessary)
        {
            if (dsu.Union(edge[0], edge[1]))
            {
                weights.Add(edge[2]);
            }
        }

        if (dsu.Components > 1)
            return -1;

        weights.Sort();

        for (var i = 0; i < k && i < weights.Count; i++)
        {
            if (weights[i] > min)
                return min;

            if (weights[i] * 2 < min)
                min = weights[i] * 2;
        }
        
        if (k < weights.Count && weights[k] < min)
            min = weights[k];

        return dsu.Components == 1 ? min : -1;
    }
}

public struct Dsu
{
    private readonly int[] _parent = [];
    public int Components = 0;

    public Dsu(int n)
    {
        _parent = new int[n];
        for (var i = 0; i < n; i++)
        {
            _parent[i] = i;
        }

        Components = n;
    }

    private int Find(int x)
    {
        if (_parent[x] != x)
            _parent[x] = Find(_parent[x]);

        return _parent[x];
    }

    public bool Union(int x, int y)
    {
        var rootX = Find(x);
        var rootY = Find(y);
        if (rootX == rootY) 
            return false;

        _parent[rootX] = rootY;
        Components--;
        return true;
    }
}