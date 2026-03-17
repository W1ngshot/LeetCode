namespace LeetCode._1727._Largest_Submatrix_With_Rearrangements;

public class Solution
{
    public int LargestSubmatrix(int[][] matrix)
    {
        var ans = 0;

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                if (i != 0 && matrix[i][j] != 0)
                    matrix[i][j] = matrix[i - 1][j] + 1;
            }

            var row = matrix[i].ToArray();
            Array.Sort(row, (a, b) => b - a);

            for (var k = 0; k < row.Length; k++)
            {
                if (row[k] == 0)
                    break;

                ans = Math.Max(ans, (k + 1) * row[k]);
            }
        }

        return ans;
    }
}