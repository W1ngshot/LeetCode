namespace LeetCode._3070._Count_Submatrices_with_Top_Left_Element_and_Sum_Less_Than_k;

public class Solution
{
    public int CountSubmatrices(int[][] grid, int k)
    {
        var result = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                grid[i][j] += (i > 0 ? grid[i - 1][j] : 0)
                              + (j > 0 ? grid[i][j - 1] : 0)
                              - (i > 0 && j > 0 ? grid[i - 1][j - 1] : 0);

                if (grid[i][j] <= k)
                    result++;
                else
                    break;
            }
        }

        return result;
    }
}