using System.Text;

namespace LeetCode._2864._Maximum_Odd_Binary_Number;

public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        var counter = s.Count(x => x == '1');
        var sb = new StringBuilder();
        for (var i = 0; i < counter - 1; i++)
        {
            sb.Append('1');
        }

        for (var i = 0; i < s.Length - counter; i++)
        {
            sb.Append('0');
        }

        sb.Append('1');
        return sb.ToString();
    }
}