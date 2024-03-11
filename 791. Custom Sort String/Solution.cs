using System.Text;

namespace LeetCode._791._Custom_Sort_String;

public class Solution
{
    public string CustomSortString(string order, string s)
    {
        var chars = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (!chars.TryAdd(ch, 1))
                chars[ch]++;
        }

        var sb = new StringBuilder();
        foreach (var ch in order)
        {
            if (chars.TryGetValue(ch, out var value))
            {
                sb.Append(ch, value);
                chars[ch] = 0;
            }
        }

        foreach (var pair in chars.Where(x => x.Value > 0))
        {
            sb.Append(pair.Key, pair.Value);
        }

        return sb.ToString();
    }
}