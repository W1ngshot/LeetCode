using System.Text;

namespace LeetCode._1544._Make_The_String_Great;

public class Solution
{
    public string MakeGood(string s)
    {
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            if (stack.Count > 0 &&
                (char.IsLower(ch) && char.ToUpper(ch) == stack.Peek()
                 || char.IsUpper(ch) && char.ToLower(ch) == stack.Peek()))
            {
                stack.Pop();
                continue;
            }
            stack.Push(ch);
        }

        var stringArray = stack.ToArray();
        var sb = new StringBuilder();
        for (var i = stringArray.Length - 1; i >= 0; i--)
        {
            sb.Append(stringArray[i]);
        }

        return sb.ToString();
    }
}