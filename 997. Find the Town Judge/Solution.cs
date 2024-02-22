namespace LeetCode._997._Find_the_Town_Judge;

public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        var ex = new HashSet<int>();
        var trusts = new int[n + 1];
        foreach (var rel in trust)
        {
            ex.Add(rel[0]);
            trusts[rel[1]]++;
        }

        for (var i = 1; i <= n; i++)
        {
            if (trusts[i] == n - 1 && !ex.Contains(i))
                return i;
        }

        return -1;
    }
}