namespace LeetCode._392._Is_Subsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;
        
        if (s.Length > t.Length)
            return false;
        
        var sPtr = 0;

        foreach (var symbol in t)
        {
            if (symbol == s[sPtr])
                sPtr++;

            if (sPtr == s.Length)
                return true;
        }

        return false;
    }
}