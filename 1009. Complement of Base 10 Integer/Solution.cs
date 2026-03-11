using System.Numerics;

namespace LeetCode._1009._Complement_of_Base_10_Integer;

public class Solution
{
    public int BitwiseComplement(int n)
    {
        var pow = BitOperations.RoundUpToPowerOf2((uint)n);
        return n == 0 ? 1 :
            n == pow ? n - 1 : (int)pow - 1 - n;
    }
}