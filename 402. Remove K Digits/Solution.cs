using System.Text;

namespace LeetCode._402._Remove_K_Digits;

public class Solution
{
    public string RemoveKdigits(string num, int k)
    {
        var sb = new StringBuilder();

        foreach (var ch in num)
        {
            while (k > 0 && sb.Length > 0 && sb[^1] > ch)
            {
                sb.Remove(sb.Length - 1, 1);
                k--;
            }
            sb.Append(ch);
        }

        while (k > 0)
        {
            sb.Remove(sb.Length - 1, 1);
            k--;
        }

        while (sb.Length > 1 && sb[0] == '0')
        {
            sb.Remove(0, 1);
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}