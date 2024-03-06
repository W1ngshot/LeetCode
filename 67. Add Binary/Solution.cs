using System.Text;

namespace LeetCode._67._Add_Binary;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int i = a.Length - 1, j = b.Length - 1, s = 0;
        var sb = new StringBuilder();
        while (i >= 0 || j >= 0 || s == 1)
        {
            if (i >= 0)
                s += a[i--] - '0';
            if (j >= 0)
                s += b[j--] - '0';
            sb.Append(s % 2);
            s /= 2;
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}