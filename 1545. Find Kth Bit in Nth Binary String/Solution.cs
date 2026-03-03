namespace LeetCode._1545._Find_Kth_Bit_in_Nth_Binary_String;

public class Solution
{
    public char FindKthBit(int n, int k)
    {
        if (n == 1 || k % 4 == 1)
            return '0';

        if (k % 4 == 3)
            return '1';

        var middle = 1 << (n - 1);
        var ans = '1';

        while (middle != k)
        {
            ans = k > middle ? '0' : '1';
            k %= middle;
            middle /= 2;
        }

        return ans;
    }
}