namespace LeetCode._1888._Minimum_Number_of_Flips_to_Make_the_Binary_String_Alternating;

public class Solution
{
    public int MinFlips(string s)
    {
        var diff = 0;
        var length = s.Length;
        for (var i = 0; i < length; i++)
            if (s[i] - '0' != (i & 1))
                diff++;

        var minDiff = diff < length - diff ? diff : length - diff;
        if (length % 2 == 0 || minDiff == 0)
            return minDiff;

        for (var i = 0; i < length; i++)
        {
            if (s[i] - '0' != (i & 1))
                diff--;
            else
                diff++;
            
            var min = diff < length - diff ? diff : length - diff;
            if (min == 0)
                return min;
            
            if (min < minDiff)
            {
                minDiff = min;
            }
        }
        
        return minDiff;
    }
}