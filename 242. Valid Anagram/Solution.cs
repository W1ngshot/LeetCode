namespace LeetCode._242._Valid_Anagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dictionary = new Dictionary<char, int>();

        foreach (var letter in s)
        {
            if (!dictionary.TryAdd(letter, 1))
                dictionary[letter]++;
        }

        foreach (var letter in t)
        {
            if (!dictionary.ContainsKey(letter) || --dictionary[letter] < 0)
                return false;
        }
        
        return true;
    }
}