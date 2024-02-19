namespace LeetCode._231._Power_of_Two;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }
}