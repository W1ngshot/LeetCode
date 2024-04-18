namespace LeetCode._463._Island_Perimeter;

public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        var counter = 0;
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 0)
                    continue;
                
                if (i + 1 >= grid.Length || grid[i + 1][j] == 0)
                    counter++;
                if (i - 1 < 0 || grid[i - 1][j] == 0)
                    counter++;
                if (j + 1 >= grid[0].Length || grid[i][j + 1] == 0)
                    counter++;
                if (j - 1 < 0 || grid[i][j - 1] == 0)
                    counter++;
            }
        }

        return counter;
    }
}