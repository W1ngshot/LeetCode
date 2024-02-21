namespace LeetCode._201._Bitwise_AND_of_Numbers_Range;

public class Solution
{
    public int RangeBitwiseAnd(int left, int right)
    {
        while (left < right)
        {
            right &= (right - 1);
        }

        return right;
    }
}