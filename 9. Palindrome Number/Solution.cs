namespace LeetCode._9._Palindrome_Number;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        var s = x.ToString();
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            if (s[l++] != s[r--])
            {
                return false;
            }
        }

        return true;
    }
}