using System.Numerics;

namespace LeetCode._762._Prime_Number_of_Set_Bits_in_Binary_Representation;

public class Solution
{
    public int CountPrimeSetBits(int left, int right)
    {
        var primes = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19 };
        var count = 0;

        for (var i = left; i <= right; i++)
        {
            var bitsCount = BitOperations.PopCount((uint)i);
            
            if (primes.Contains(bitsCount))
                count++;
        }
        
        return count;
    }
}