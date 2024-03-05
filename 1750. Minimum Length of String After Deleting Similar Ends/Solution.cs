namespace LeetCode._1750._Minimum_Length_of_String_After_Deleting_Similar_Ends;

public class Solution
{
    public int MinimumLength(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r && s[l] == s[r])
        {
            var ch = s[l];
            while (l < r && s[l] == ch)
                l++;
            while (l < r && s[r] == ch)
                r--;
        }

        return s.Length - l * 2;
    }
}