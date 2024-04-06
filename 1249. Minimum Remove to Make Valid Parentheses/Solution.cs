using System.Text;

namespace LeetCode._1249._Minimum_Remove_to_Make_Valid_Parentheses;

public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        var openedStack = new Stack<int>();
        var excluded = new HashSet<int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                openedStack.Push(i);
            if (s[i] == ')' && !openedStack.TryPop(out _))
            {
                excluded.Add(i);
            }
        }

        while (openedStack.TryPop(out var index))
        {
            excluded.Add(index);
        }

        var sb = new StringBuilder();
        for (var i = 0; i < s.Length; i++)
        {
            if (!excluded.Contains(i))
                sb.Append(s[i]);
        }

        return sb.ToString();
    }
}