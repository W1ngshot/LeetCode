namespace LeetCode._1878._Get_Biggest_Three_Rhombus_Sums_in_a_Grid;

public class Answer
{
    private readonly int[] _ans = new int[3];

    public void Put(int x)
    {
        if (x > _ans[0])
        {
            _ans[2] = _ans[1];
            _ans[1] = _ans[0];
            _ans[0] = x;
        }
        else if (x != _ans[0] && x > _ans[1])
        {
            _ans[2] = _ans[1];
            _ans[1] = x;
        }
        else if (x != _ans[0] && x != _ans[1] && x > _ans[2])
        {
            _ans[2] = x;
        }
    }

    public int[] Get() => _ans.Where(num => num != 0).ToArray();
}

public class Solution
{
    public int[] GetBiggestThree(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var sum1 = new int[m + 1, n + 2];
        var sum2 = new int[m + 1, n + 2];

        for (var i = 1; i <= m; ++i)
        {
            for (var j = 1; j <= n; ++j)
            {
                sum1[i, j] = sum1[i - 1, j - 1] + grid[i - 1][j - 1];
                sum2[i, j] = sum2[i - 1, j + 1] + grid[i - 1][j - 1];
            }
        }

        var ans = new Answer();
        for (var i = 0; i < m; ++i)
        {
            for (var j = 0; j < n; ++j)
            {
                ans.Put(grid[i][j]);
                for (var k = i + 2; k < m; k += 2)
                {
                    int lx = (i + k) / 2, ly = j - (k - i) / 2;
                    int rx = (i + k) / 2, ry = j + (k - i) / 2;
                    if (ly < 0 || ry >= n)
                        break;

                    var sum = (sum2[lx + 1, ly + 1] - sum2[i, j + 2]) +
                              (sum1[rx + 1, ry + 1] - sum1[i, j]) +
                              (sum1[k + 1, j + 1] - sum1[lx, ly]) +
                              (sum2[k + 1, j + 1] - sum2[rx, ry + 2]) -
                              (grid[i][j] + grid[k][j] + grid[lx][ly] +
                               grid[rx][ry]);
                    ans.Put(sum);
                }
            }
        }

        return ans.Get();
    }
}