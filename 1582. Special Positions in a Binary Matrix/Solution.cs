namespace LeetCode._1582._Special_Positions_in_a_Binary_Matrix;

public class Solution
{
    public int NumSpecial(int[][] mat)
    {
        foreach (var row in mat)
        {
            var index = -1;
            for (var n = 0; n < mat[0].Length; n++)
            {
                if (row[n] != 1)
                    continue;

                if (index != -1)
                {
                    row[index] = -1;
                    row[n] = -1;
                }

                if (index == -1)
                    index = n;
            }
        }

        var counter = 0;
        for (var n = 0; n < mat[0].Length; n++)
        {
            var isCounted = false;
            foreach (var row in mat)
            {
                if (row[n] == -1)
                {
                    if (isCounted)
                        counter--;
                    break;
                }

                if (row[n] != 1)
                    continue;

                if (isCounted)
                {
                    counter--;
                    break;
                }

                isCounted = true;
                counter++;
            }
        }

        return counter;
    }
}