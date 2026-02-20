namespace LeetCode._696._Count_Binary_Substrings;

public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        var list = new List<int> {1};
        var index = 0;
        var count = 0;
        
        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
                list[index]++;
            else
            {
                list.Add(1);
                index++;
            }
        }

        for (var i = 1; i < list.Count; i++)
        {
            count += Math.Min(list[i - 1], list[i]);
        }
        
        return count;
    }
}