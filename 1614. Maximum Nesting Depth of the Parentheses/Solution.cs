namespace LeetCode._1614._Maximum_Nesting_Depth_of_the_Parentheses;

public class Solution
{
    public int MaxDepth(string s)
    {
        var stack = new Stack<char>();
        var max = 0;
        foreach (var ch in s)
        {
            if (ch == '(')
            {
                stack.Push('(');
                if (stack.Count > max)
                    max = stack.Count;
            }

            if (ch == ')')
                stack.Pop();
        }

        return max;
    }
}