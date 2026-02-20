namespace LeetCode._125._Valid_Palindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var p1 = 0;
        var p2 = s.Length - 1;
        var span = s.AsSpan();
        
        
        while (p1 < p2)
        {
            if (!char.IsLetterOrDigit(span[p1]))
            {
                p1++;
                continue;
            }

            if (!char.IsLetterOrDigit(span[p2]))
            {
                p2--;
                continue;
            }

            if (char.ToUpperInvariant(span[p1]) != char.ToUpperInvariant(span[p2]))
            {
                return false;
            }

            p1++;
            p2--;
        }
        return true;
    }
}