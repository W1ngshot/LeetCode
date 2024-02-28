namespace LeetCode._513._Find_Bottom_Left_Tree_Value;

//Definition for a binary tree node.
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}

public class Solution
{
    public int FindBottomLeftValue(TreeNode root)
    {
        var stack = new Stack<Tuple<TreeNode, int>>();
        stack.Push(new (root, 1));
        int height = 0, value = 0;

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current.Item2 >= height)
            {
                height = current.Item2;
                value = current.Item1.val;
            }
            
            if (current.Item1.left is not null)
                stack.Push(new (current.Item1.left, current.Item2 + 1));
            if (current.Item1.right is not null)
                stack.Push(new (current.Item1.right, current.Item2 + 1));
        }

        return value;
    }
}