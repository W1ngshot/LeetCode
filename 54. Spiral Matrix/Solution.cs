namespace LeetCode._54._Spiral_Matrix;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int n = matrix.Length, m = matrix[0].Length;
        var res = new List<int>();
        for (var i = 0; i < Math.Min((n + 1) / 2, (m + 1) / 2); i++)
        {
            for (var j = i; j < m - i; j++)
            {
                res.Add(matrix[i][j]);
            }

            for (var j = i + 1; j < n - i; j++)
            {
                res.Add(matrix[j][m - i - 1]);
            }

            for (var j = m - i - 2; j >= i; j--)
            {
                if (n - i - 1 != i)
                {
                    res.Add(matrix[n - i - 1][j]);
                }
            }

            for (var j = n - i - 2; j > i; j--)
            {
                if (i != m - i - 1)
                {
                    res.Add(matrix[j][i]);
                }
            }
        }

        return res.ToArray();
    }
}