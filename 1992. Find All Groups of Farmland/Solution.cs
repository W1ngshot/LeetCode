namespace LeetCode._1992._Find_All_Groups_of_Farmland;

public class Solution
{
    public int[][] FindFarmland(int[][] land)
    {
        var result = new List<int[]>();

        for (var i = 0; i < land.Length; i++)
        {
            for (var j = 0; j < land[0].Length; j++)
            {
                if (land[i][j] == 1)
                {
                    var coordinates = GetBoundaries(land, i, j);
                    result.Add(coordinates);
                }
            }
        }

        return result.ToArray();
    }

    private int[] GetBoundaries(int[][] land, int row, int col)
    {
        var r2 = row;
        var c2 = col;

        while (r2 < land.Length && land[r2][col] == 1) r2++;
        while (c2 < land[0].Length && land[row][c2] == 1) c2++;

        for (var i = row; i < r2; i++)
        {
            for (var j = col; j < c2; j++)
            {
                land[i][j] = 0;
            }
        }

        return [row, col, r2 - 1, c2 - 1];
    }
}