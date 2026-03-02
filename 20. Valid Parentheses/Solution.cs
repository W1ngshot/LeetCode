namespace LeetCode._20._Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var ch in s)
        {
            switch (ch)
            {
                case '(' or '[' or '{':
                    stack.Push(ch);
                    break;
                case ')' or ']' or '}'
                    when !stack.TryPop(out var top) || GetMatch(top) != ch:
                    return false;
            }
        }

        return stack.Count == 0;
    }

    private static char GetMatch(char ch) =>
        ch switch
        {
            '(' => ')',
            '[' => ']',
            '{' => '}',
            _ => '0'
        };
}