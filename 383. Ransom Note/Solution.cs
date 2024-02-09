namespace LeetCode._383._Ransom_Note;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var a = ransomNote
            .ToCharArray()
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
        var b = magazine
            .ToCharArray()
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());

        foreach (var key in a.Keys)
        {
            if (!b.TryGetValue(key, out var value) || value < a[key])
            {
                return false;
            }
        }

        return true;
    }
}