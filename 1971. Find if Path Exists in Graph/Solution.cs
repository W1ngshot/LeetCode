namespace LeetCode._1971._Find_if_Path_Exists_in_Graph;

public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        if (n == 1 || source == destination)
            return true;

        var edgesMap = new Dictionary<int, List<int>>();

        foreach (var edge in edges)
        {
            AddEdge(edgesMap, edge[0], edge[1]);
            AddEdge(edgesMap, edge[1], edge[0]);
        }
        
        var visitedVertexes = new HashSet<int>();
        
        return IsPath(visitedVertexes, edgesMap, source, destination);
    }

    private void AddEdge(Dictionary<int, List<int>> edgeMap, int key, int value)
    {
        if (edgeMap.TryGetValue(key, out var list))
        {
            list.Add(value);
            return;
        }

        edgeMap.Add(key, [value]);
    }

    private bool IsPath(HashSet<int> visitedVertices, Dictionary<int, List<int>> edgesMap, int source, int destination)
    {
        if (!visitedVertices.Add(source))
            return false;

        return edgesMap[source].Contains(destination) ||
               edgesMap[source].Any(vertex => IsPath(visitedVertices, edgesMap, vertex, destination));
    }
}