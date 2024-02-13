namespace LeetCode._2108._Find_First_Palindromic_String_in_the_Array;

public class Solution
{
    public string FirstPalindrome(string[] words)
    {
        foreach (var str in words)
        {
            int l = 0, r = str.Length - 1;
            var isP = true;
            while (l < r)
            {
                if (str[l++] != str[r--])
                {
                    isP = false;
                    break;
                }
            }

            if (isP)
            {
                return str;
            }
        }

        return "";
    }
}