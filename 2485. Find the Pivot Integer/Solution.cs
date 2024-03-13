namespace LeetCode._2485._Find_the_Pivot_Integer;

public class Solution
{
    public int PivotInteger(int n)
    {
        var sum = (1 + n) * n / 2;
        var newSum = 0;
        for (var i = n; i > 0; i--)
        {
            if (newSum == (sum - i) / 2d)
                return i;
            if (newSum > (sum - i) / 2d)
                return -1;
            newSum += i;
        }
        return -1;
    }
}