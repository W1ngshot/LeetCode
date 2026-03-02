namespace LeetCode._1536._Minimum_Swaps_to_Arrange_a_Binary_Grid;

public class Solution
{
    public int MinSwaps(int[][] grid)
    {
        var rowsRightZeros = new int[grid.Length];

        for (var i = 0; i < grid.Length; i++)
        {
            var counter = 0;
            for (var j = grid.Length - 1; j >= 0; j--)
            {
                if (grid[i][j] != 0)
                    break;

                counter++;
            }

            rowsRightZeros[i] = counter;
        }

        var swapCounter = 0;
        for (var i = 0; i < rowsRightZeros.Length; i++)
        {
            if (rowsRightZeros[i] >= rowsRightZeros.Length - 1 - i)
                continue;

            var index = -1;
            for (var j = i + 1; j < rowsRightZeros.Length; j++)
            {
                if (rowsRightZeros[j] < rowsRightZeros.Length - 1 - i) 
                    continue;
                
                index = j;
                break;
            }
            
            if (index == -1)
                return -1;

            for (var j = index; j > i; j--)
            {
                (rowsRightZeros[j], rowsRightZeros[j - 1]) = (rowsRightZeros[j - 1], rowsRightZeros[j]);
                swapCounter++;
            }
        }
        
        return swapCounter;
    }
}