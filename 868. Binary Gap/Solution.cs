namespace LeetCode._868._Binary_Gap;

public class Solution
{
    public int BinaryGap(int n)
    {
        var binary = Convert.ToString(n, 2);
        var count = 0;
        var prevPtr = 0;

        for (var i = 1; i < binary.Length; i++)
        {
            if (binary[i] != '1')
                continue;

            count = i - prevPtr > count ? i - prevPtr : count;
            prevPtr = i;
        }

        return count;
    }
}