using System.Collections;

namespace LeetCode._1461._Check_If_a_String_Contains_All_Binary_Codes_of_Size_K;

public class Solution
{
    public bool HasAllCodes(string s, int k)
    {
        var combinations = 1 << k;
        
        if (s.Length < combinations - 1 + k)
            return false;
        
        var bitArray = new BitArray(combinations);
        var mask = combinations - 1;
        
        var current = 0;
        for (var i = 0; i < k - 1; i++)
        {
            current = (current << 1) | (s[i] & 1);
        }

        for (var i = k - 1; i < s.Length; i++)
        {
            current = ((current << 1) & mask) | (s[i] & 1);

            if (bitArray[current]) 
                continue;
            
            bitArray[current] = true;
            combinations--;
            
            if (combinations == 0)
                return true;
        }

        return false;
    }
}