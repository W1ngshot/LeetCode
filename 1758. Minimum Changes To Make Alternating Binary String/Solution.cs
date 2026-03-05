namespace LeetCode._1758._Minimum_Changes_To_Make_Alternating_Binary_String;

public class Solution
{
    public int MinOperations(string s)
    {
        var oddFirst = 0;
        var evenFirst = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0 && s[i] == '0'
                || i % 2 == 1 && s[i] == '1')
                oddFirst++;

            if (i % 2 == 0 && s[i] == '1'
                || i % 2 == 1 && s[i] == '0')
                evenFirst++;
        }

        return Math.Min(oddFirst, evenFirst);
    }
}