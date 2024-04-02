namespace LeetCode._205._Isomorphic_Strings;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var dictS = new Dictionary<char, char>();
        var dictT = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            if (dictS.TryGetValue(s[i], out var symbol))
            {
                if (symbol != t[i])
                    return false;
            }
            else if (dictT.ContainsKey(t[i]))
            {
                return false;
            }
            else
            {
                dictS[s[i]] = t[i];
                dictT[t[i]] = s[i];
            }
        }

        return true;
    }
}