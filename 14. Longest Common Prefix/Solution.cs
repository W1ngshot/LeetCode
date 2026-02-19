namespace LeetCode._14._Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var prefix = strs[0].AsSpan();

        for (var i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < prefix.Length)
                prefix = prefix[..strs[i].Length];
            
            for (var j = 0; j < strs[i].Length; j++)
            {
                if (prefix.Length <= j)
                    continue;
                
                if (prefix[j] != strs[i][j])
                    prefix = j == 0 ? new ReadOnlySpan<char>() : prefix[..j];
            }

            if (prefix.Length == 0)
                return prefix.ToString();
        }

        return prefix.ToString();
    }
}