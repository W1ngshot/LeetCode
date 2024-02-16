namespace LeetCode._498._Diagonal_Traverse;

public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        var res = new List<int>();
        int n = mat.Length, m = mat[0].Length;
        for (var i = 0; i < n + m + 1; i++)
        {
            if (i % 2 == 1)
            {
                for (var j = Math.Max(i - m + 1, 0); j < Math.Min(i + 1, n); j++)
                {
                    res.Add(mat[j][i - j]);
                }
            }
            else
            {
                for (var j = Math.Min(i, n - 1); j >= Math.Max(i - m + 1, 0); j--)
                {
                    res.Add(mat[j][i - j]);
                }
            }
        }

        return res.ToArray();
    }
}